﻿#pragma checksum "..\..\..\Auth.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94BD26F22FF46D7EA0AFF76D1BB7231A413F5C1B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using project_PP;


namespace project_PP {
    
    
    /// <summary>
    /// Auth
    /// </summary>
    public partial class Auth : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_email;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tb_password;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_show_password;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_password_show;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_entry;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/project_PP;component/auth.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Auth.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 35 "..\..\..\Auth.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click_Auth_how_guest);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.cb_show_password = ((System.Windows.Controls.CheckBox)(target));
            
            #line 41 "..\..\..\Auth.xaml"
            this.cb_show_password.Unchecked += new System.Windows.RoutedEventHandler(this.cb_show_password_Unchecked);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\Auth.xaml"
            this.cb_show_password.Checked += new System.Windows.RoutedEventHandler(this.cb_show_password_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tb_password_show = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\Auth.xaml"
            this.tb_password_show.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_password_show_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_entry = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Auth.xaml"
            this.btn_entry.Click += new System.Windows.RoutedEventHandler(this.btn_entry_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 45 "..\..\..\Auth.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

