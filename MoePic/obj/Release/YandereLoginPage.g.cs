﻿#pragma checksum "C:\Users\HIGAN\documents\visual studio 2013\Projects\MoePic\MoePic\YandereLoginPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DE6D8C0391E2BB4A5D29A435B208823"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MoePic.Models;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace MoePic {
    
    
    public partial class YandereLoginPage : MoePic.Models.MoePicPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox name;
        
        internal System.Windows.Controls.PasswordBox password;
        
        internal System.Windows.Controls.TextBlock ErrorInfo;
        
        internal System.Windows.Controls.Grid nowLogining;
        
        internal System.Windows.Controls.ProgressBar pro;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/MoePic;component/YandereLoginPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.name = ((System.Windows.Controls.TextBox)(this.FindName("name")));
            this.password = ((System.Windows.Controls.PasswordBox)(this.FindName("password")));
            this.ErrorInfo = ((System.Windows.Controls.TextBlock)(this.FindName("ErrorInfo")));
            this.nowLogining = ((System.Windows.Controls.Grid)(this.FindName("nowLogining")));
            this.pro = ((System.Windows.Controls.ProgressBar)(this.FindName("pro")));
        }
    }
}

