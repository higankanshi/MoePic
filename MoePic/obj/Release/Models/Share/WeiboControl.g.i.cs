﻿#pragma checksum "C:\Users\HIGAN\documents\visual studio 2013\Projects\MoePic\MoePic\Models\Share\WeiboControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "77DAE68796EB9708A23DEE11EF7AFFAF"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace MoePic.Models {
    
    
    public partial class WeiboControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard InputOut;
        
        internal System.Windows.Media.Animation.Storyboard InputIn;
        
        internal Microsoft.Phone.Controls.WebBrowser webViewer;
        
        internal System.Windows.Controls.Grid weiboInput;
        
        internal System.Windows.Controls.TextBox contentText;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MoePic;component/Models/Share/WeiboControl.xaml", System.UriKind.Relative));
            this.InputOut = ((System.Windows.Media.Animation.Storyboard)(this.FindName("InputOut")));
            this.InputIn = ((System.Windows.Media.Animation.Storyboard)(this.FindName("InputIn")));
            this.webViewer = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("webViewer")));
            this.weiboInput = ((System.Windows.Controls.Grid)(this.FindName("weiboInput")));
            this.contentText = ((System.Windows.Controls.TextBox)(this.FindName("contentText")));
        }
    }
}
