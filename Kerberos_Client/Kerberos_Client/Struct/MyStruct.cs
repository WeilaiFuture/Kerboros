﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Kerberos_Client
{
    public class MyStruct
    {
        public Certificate certificate { get; set; } //证书
        public My_k my_k { get; set; }
        public Message1 message1 { get; set; }
        public Message2 message2 { get; set; }
        public Ticket ticket { get; set; }
        public Message3 message3 { get; set; }
        public Message4 message4 { get; set; }
        public Message5 message5 { get; set; }
        public Message6 message6 { get; set; }
        public User user { get; set; }
        public Friend friend { get; set; }
        public Chat_Message chat_message { get; set; }
        public Group group { get; set; }
        public List<Friend> friendlist { get; set; }
        public List<Group> groups { get; set; }

        #region 证书
        public class Certificate
        {
            string version;//版本号
            string serial;//序列号
            string deadline;//有效日期
            string name;//主体名
            string pk;//公钥
            public string Version
            {
                get { return version; }
                set { version = value; }
            }
            public string Serial
            {
                get { return serial; }
                set { serial = value; }
            }
            public string Deadline
            {
                get { return deadline; }
                set { deadline = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Pk
            {
                get { return pk; }
                set { pk = value; }
            }
        }
        #endregion
        #region 对称钥
        public class My_k
        {
            string key; //对称钥
            public string Key
            {
                get { return key; }
                set { key = value; }
            }
        }
        #endregion
        #region 认证数据结构
        #region 报文1
        public class Message1
        {
            string idc; //用户号
            string idt; //tgs
            string ts;  //时间戳
            public string IDC
            {
                get { return idc; }
                set { idc = value; }
            }
            public string IDT
            {
                get { return idt; }
                set { idt = value; }
            }
            public string TS
            {
                get { return ts; }
                set { ts = value; }
            }
        }
        #endregion
        #region 报文2
        public class Message2
        {
            string key; //session key
            string idt; //tgs
            string ts;  //签发时间
            string lifetime; //有效期
            string t;   //票据
            public string Key
            {
                get { return key; }
                set { key = value; }
            }

            public string IDT
            {
                get { return idt; }
                set { idt = value; }
            }

            public string TS
            {
                get { return ts; }
                set { ts = value; }
            }

            public string Lifetime
            {
                get { return lifetime; }
                set { lifetime = value; }
            }

            public string T
            {
                get { return t; }
                set { t = value; }
            }
        }
        #endregion
        #region 票据
        public class Ticket
        {
            string key;//Session key
            string idc;//用户标识符
            string adc;//client 地址
            string idt;//tgs
            string ts;//时间戳
            string lifetime;//有效期
            public string Key
            {
                get { return key; }
                set { key = value; }
            }
            public string IDC
            {
                get { return idc; }
                set { idc = value; }
            }
            public string ADC
            {
                get { return adc; }
                set { adc = value; }
            }
            public string IDT
            {
                get { return idt; }
                set { idt = value; }
            }
            public string TS
            {
                get { return ts; }
                set { ts = value; }
            }
            public string Lifetime
            {
                get { return lifetime; }
                set { lifetime = value; }
            }
        }
        #endregion
        #region 报文3
        public class Message3
        {
            string idv;//v的id
            string t;//票据
            string ac;//认证
            public string IDV
            {
                get { return idv; }
                set { idv = value; }
            }
            public string T
            {
                get { return t; }
                set { t = value; }
            }
            public string AC
            {
                get { return ac; }
                set { ac = value; }
            }
        }
        #endregion
        #region 报文4
        public class Message4
        {
            string key;//session key
            string idv;//v的id
            string ts;//时间戳
            string t;//票据
            public string Key
            {
                get { return key; }
                set { key = value; }
            }
            public string IDv
            {
                get { return idv; }
                set { idv = value; }
            }
            public string TS
            {
                get { return ts; }
                set { ts = value; }
            }
            public string T
            {
                get { return t; }
                set { t = value; }
            }
        }
        #endregion
        #region 认证
        public class Authenticator
        {
            string idc;//Ticket主人id
            string adc;//Ticket主人地址
            string ts;//签发时间
            public string IDC
            {
                get { return idc; }
                set { idc = value; }
            }
            public string ADC
            {
                get { return adc; }
                set { adc = value; }
            }
            public string TS
            {
                get { return ts; }
                set { ts = value; }
            }
        }
        #endregion
        #region 报文5
        public class Message5
        {
            string t;//票据
            string ac;//认证
            public string T
            {
                get { return t; }
                set { t = value; }
            }
            public string AC
            {
                get { return ac; }
                set { ac = value; }
            }
        }
        #endregion
        #region 报文6
        public class Message6
        {
            string ts;//时间戳
            public string TS
            {
                get { return ts; }
                set { ts = value; }
            }
        }
        #endregion
        #endregion
        #region 用户
        public class User
        {
            string photo;
            public string Photo
            {
                get { return photo; }
                set
                {
                    if (File.Exists(@value))
                        photo = value;
                    else
                    {
                        photo = @"../../Image_Source\未登录头象.png";
                    }
                }
            }//图片在本机的地址
            public string Uname { get; set; }//用户昵称
            public string Uid { get; set; }//用户账号
            public string Psswd { get; set; }//用户密码
            public string Name { get; set; }//用户真实姓名
            public string Sign { get; set; }//个性签名
            public string Email { get; set; }//邮箱
            public int Gender { get; set; }//性别
            public int Status { get; set; }//状态
            public long StartTime { get; set; }//注册时间
            public User()
            {
                Uid = "123456789";
                Uname = "test";
                Name = "test";
                Psswd = "0";
                Sign = "0";
                Photo = "../Image_Source/test.jpg";
                Email = Uid + "@123.com";
                Gender = 0;
                Status = 0;
                StartTime = 0;
            }
            public User(User user)
            {
                Photo = user.Photo;
                Uname = user.Uname;
                Uid = user.Uid;
                Psswd = user.Psswd;
                Name = user.Name;
                Sign = user.Sign;
                Email = user.Email;
                Gender = user.Gender;
                Status = user.Status;
                StartTime = user.StartTime;
            }
            public User(string id, string psw,string photo)
            {
                Uid = id;
                Psswd = psw;
                Photo = photo;
            }
            public User(string id, string psw)
            {
                Uid = id;
                Psswd = psw;
            }
        }

        public class Login_User
        {
            public string Uid { get; set; }
            public string Psswd { get; set; }
            public string Photo { get; set; }
            public bool? Remember { get; set; }
            public bool? Automatic { get; set; }
            public Login_User()
            {
                Photo = "../../Image_Source/test.jpg";
            }
            public Login_User(Login_User u)
            {
                Uid = u.Uid;
                Psswd = u.Psswd;
                Photo = u.Photo;
                Remember = u.Remember;
                Automatic = u.Automatic;
            }

            public Login_User(string id, string psw, string photo, bool? rem, bool? auto)
            {
                Uid = id;
                Psswd = psw;
                Photo = photo;
                //Photo = "../../Image_Source/test.jpg";
                Remember = rem;
                Automatic = auto;
            }

        }
        #region 好友
        public class Friend
        {
            public User U { get; set; }//用户信息
            string remark;//备注
            int startTime;//添加好友时间
            string tid;//分组信息
            public string Remark
            {
                get { return remark; }
                set { remark = value; }
            }
            public int StartTime
            {
                get { return startTime; }
                set { startTime = value; }
            }
            public string Tid
            {
                get { return tid; }
                set { tid = value; }
            }
        }
        #endregion
        #endregion
        #region 聊天信息
        public abstract class Chat_information:Add_Chat
        {
            public string Last_Message { get; set; }
            public string Last_Time { get; set; }
            public string Photo { get; set; }
            public string Name { get; set; }
            public string Id { get; set; }
            public List<Chat_Message> Messages_list { get; set; }
            public abstract void Add(Chat_Message chat_Message);
        }
        interface Add_Chat
        {
            public abstract void Add(Chat_Message chat_Message);
        }
        public class Person_Chat : Chat_information
        { 
            public Person_Chat(string P,string N,string I)
            {
                Photo = P;
                Name = N;
                Id = I;
                Messages_list = new List<Chat_Message>();
            }
            public override void Add(Chat_Message chat_Message)
            {
                Messages_list.Add(chat_Message);
                Last_Message =chat_Message.Content;
                DateTime d=new DateTime(chat_Message.Time);
                Last_Time = d.ToString();
            }
        }
        public class Group_Chat : Chat_information
        {
            public Group_Chat(string P, string N, string I)
            {
                Photo = P;
                Name = N;
                Id = I;
                Messages_list = new List<Chat_Message>();
            }
            public override void Add(Chat_Message chat_Message)
            {
                Messages_list.Add(chat_Message);
                Last_Message = chat_Message.U.Uname + ":" + chat_Message.Content;
                DateTime d = new DateTime(chat_Message.Time);
                Last_Time = d.ToString();
            }
        }
        public class Chat_Message
        {
            string content;//信息内容
            User u;//发送方
            long time;//时间戳
            public string Content
            {
                get { return content; }
                set { content = value; }
            }
            public User U
            {
                get { return u; }
                set { u = value; }
            }
            public long Time
            {
                get { return time; }
                set { time = value; }
            }
        }
        #endregion
        #region 群信息
        public class Group
        {
            public List<User> list;//用户列表
            string gid;//群账号
            string photo;//群头像
            string leader;//群主账号
            string sign;//群介绍
            long startTime;//创建时间

            public string Gid
            {
                get { return gid; }
                set { gid = value; }
            }
            public string Photo
            {
                get { return photo; }
                set { photo = value; }
            }
            public string Leader
            {
                get { return leader; }
                set { leader = value; }
            }
            public string Sign
            {
                get { return sign; }
                set { sign = value; }
            }
            public long StartTime
            {
                get { return startTime; }
                set { startTime = value; }
            }
        }
        #endregion
       
        public class img
        {
             public static BitmapImage GetBitmap(string path)
            {
                BitmapImage bi;
                if (!File.Exists(path))
                    path = @"../../Image_Source\未登录头象.png";
                using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(path)))
                {
                    bi = new BitmapImage();
                    bi.BeginInit();
                    bi.CacheOption = BitmapCacheOption.OnLoad;//设置缓存模式
                    bi.StreamSource = ms;//通过StreamSource加载图片
                    bi.EndInit();
                    bi.Freeze();
                }
                return bi;
            }
        }
    }
}

