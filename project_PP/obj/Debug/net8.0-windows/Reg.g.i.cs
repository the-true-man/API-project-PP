﻿#pragma checksum "..\..\..\Reg.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2D2D39A4FD5095E889DAF21EDE00C6586A75C7B9"
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
    /// Reg
    /// </summary>
    public partial class Reg : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_lastname;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_name;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_midname;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_email;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tb_password;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_password_show;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_show_password;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Reg.xaml"
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
            System.Uri resourceLocater = new System.Uri("/project_PP;component/reg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Reg.xaml"
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
            this.tb_lastname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_midname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.tb_password_show = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\..\Reg.xaml"
            this.tb_password_show.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_password_show_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cb_show_password = ((System.Windows.Controls.CheckBox)(target));
            
            #line 54 "..\..\..\Reg.xaml"
            this.cb_show_password.Unchecked += new System.Windows.RoutedEventHandler(this.cb_show_password_Unchecked);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\Reg.xaml"
            this.cb_show_password.Checked += new System.Windows.RoutedEventHandler(this.cb_show_password_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_entry = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Reg.xaml"
            this.btn_entry.Click += new System.Windows.RoutedEventHandler(this.btn_entry_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 57 "..\..\..\Reg.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

