﻿#pragma checksum "..\..\..\UI\User_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CB282DD6F90DE2198C11B3802FCDBBB5CD3FE32C56B9EDCE0FF80D2FACFAE8E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Client;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Client {
    
    
    /// <summary>
    /// User_Window
    /// </summary>
    public partial class User_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\UI\User_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid my_Grid;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UI\User_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image head_Image;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\UI\User_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock name_Block;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\UI\User_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sign_Tb;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\UI\User_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_Tb;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\UI\User_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander my_Exp;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\UI\User_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid friend_List;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\UI\User_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander my_Exp1;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\UI\User_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid friend_List1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Client;component/ui/user_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\User_Window.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\UI\User_Window.xaml"
            ((Client.User_Window)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.my_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.head_Image = ((System.Windows.Controls.Image)(target));
            
            #line 40 "..\..\..\UI\User_Window.xaml"
            this.head_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.head_Image_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 46 "..\..\..\UI\User_Window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.name_Block = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.sign_Tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 84 "..\..\..\UI\User_Window.xaml"
            this.sign_Tb.GotFocus += new System.Windows.RoutedEventHandler(this.Tb_GotFocus);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\UI\User_Window.xaml"
            this.sign_Tb.LostFocus += new System.Windows.RoutedEventHandler(this.Tb_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.search_Tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 95 "..\..\..\UI\User_Window.xaml"
            this.search_Tb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\UI\User_Window.xaml"
            this.search_Tb.GotFocus += new System.Windows.RoutedEventHandler(this.Tb_GotFocus);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\UI\User_Window.xaml"
            this.search_Tb.LostFocus += new System.Windows.RoutedEventHandler(this.Tb_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.my_Exp = ((System.Windows.Controls.Expander)(target));
            return;
            case 9:
            this.friend_List = ((System.Windows.Controls.DataGrid)(target));
            
            #line 107 "..\..\..\UI\User_Window.xaml"
            this.friend_List.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.friend_List_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.my_Exp1 = ((System.Windows.Controls.Expander)(target));
            return;
            case 11:
            this.friend_List1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 136 "..\..\..\UI\User_Window.xaml"
            this.friend_List1.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.friend_List_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

