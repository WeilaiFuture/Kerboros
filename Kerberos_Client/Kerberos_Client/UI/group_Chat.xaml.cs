﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Kerberos_Client.MyStruct;

namespace Kerberos_Client.UI
{
    /// <summary>
    /// group_Chat.xaml 的交互逻辑
    /// </summary>
    public partial class group_Chat : Window
    {
        public ObservableCollection<ChatMessage> chatMessage = new ObservableCollection<ChatMessage>();
        public User My_user;
        public Group Chat_user;
        Main_Window window;
        public group_Chat(Group group, User u, Main_Window w)
        {
            window = w;
            InitializeComponent();
            Chat_user = group;
            My_user = u;
            head_Image.Source = img.GetBitmap(group.Photo);
            Uname_TextBlock.Text = "群账号:" + Chat_user.Gid;
            Uid_TX.Text = "群主:" + Chat_user.Leader;
            ListBoxChat.ItemsSource = chatMessage;
            group_List.ItemsSource = Chat_user.list;
            init();
        }
        private void init()
        {
            FileStream sr = null;
            string path = @My_user.Uid + "/" + Chat_user.Gid + ".txt";
            sr = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader streamReader = new StreamReader(sr);
            string json = string.Empty;
            while ((json = streamReader.ReadLine()) != null)
            {
                ChatMessage U = JsonHelper.FromJson<ChatMessage>(json);
                chatMessage.Add(U);
            }
            streamReader.Close();
            sr.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Chat_Message chat = new Chat_Message();
            chat.U = My_user;
            chat.Content = send_text.Text;
            chat.Time = DateTime.Now.Ticks;
            MyStruct myStruct = new MyStruct();
            myStruct.chat_message = chat;
            myStruct.user = My_user;
            myStruct.group = Chat_user;
            Order order = new Order();
            order.Dst = Chat_user.Gid;
            order.Src = My_user.Uid;
            order.MsgType = "2002";
            order.ContentType = "101"; 
            order.Extend = JsonHelper.ToJson(myStruct);
            order.Extend = DESLibrary.EncryptDES(JsonHelper.ToJson(myStruct), Main_Window.Keys["server"]);
            ConnectServer.sendMessage(order);

            Chat_Message chat_Message = myStruct.chat_message;
            Chat_information record = Main_Window.Message_List.Find
                (delegate (Chat_information record_)
                { return record_.Id.Equals(Chat_user.Gid); });
            if (record != null)
            {
                record.Add(chat_Message);
            }
            else
            {
                record = new Group_Chat(Chat_user.Photo, Chat_user.Gid, Chat_user.Gid);
                record.Add(chat_Message);
                Main_Window.Message_List.Add(record);
            }
            window.message_List.ItemsSource = null;
            window.message_List.ItemsSource = Main_Window.Message_List;
            chatMessage.Add(new ChatMessage()
            {
                Name = My_user.Uname,
                Time = DateTime.Now.ToString(),
                Photo = My_user.Photo,
                Message = send_text.Text,
                MessageLocation = TypeLocalMessageLocation.chatSend
            }); ;
            send_text.Text = "";
            ListBoxChat.ScrollIntoView(ListBoxChat.Items[ListBoxChat.Items.Count - 1]);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            FileStream sr = null;
            string path = @My_user.Uid + "/" + Chat_user.Gid + ".txt";
            sr = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(sr);
            string json = string.Empty;
            foreach (object i in chatMessage)
            {
                ChatMessage m = i as ChatMessage;
                json = JsonHelper.ToJson(m);
                sw.WriteLine(json);
            }
            sw.Close();
            sr.Close();
            Main_Window.Chat_Dic.Remove(Chat_user.Gid);
            base.OnClosing(e);
        }
    }
}