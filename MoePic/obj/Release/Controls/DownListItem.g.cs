﻿#pragma checksum "C:\Users\HIGAN\documents\visual studio 2013\Projects\MoePic\MoePic\Controls\DownListItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7E676F481B54E1ECB9B65EB58DC13414"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace MoePic.Controls {
    
    
    public partial class DownListItem : System.Windows.Controls.ListBoxItem {
        
        internal System.Windows.Controls.ListBoxItem listBoxItem;
        
        internal System.Windows.Media.Animation.Storyboard ItemHide;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image DownloadImage;
        
        internal System.Windows.Controls.Image SmapleImage;
        
        internal System.Windows.Controls.TextBlock Tilte;
        
        internal System.Windows.Controls.ProgressBar ProgressBar;
        
        internal System.Windows.Controls.TextBlock InfoText;
        
        internal System.Windows.Controls.TextBlock ProgressText;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MoePic;component/Controls/DownListItem.xaml", System.UriKind.Relative));
            this.listBoxItem = ((System.Windows.Controls.ListBoxItem)(this.FindName("listBoxItem")));
            this.ItemHide = ((System.Windows.Media.Animation.Storyboard)(this.FindName("ItemHide")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.DownloadImage = ((System.Windows.Controls.Image)(this.FindName("DownloadImage")));
            this.SmapleImage = ((System.Windows.Controls.Image)(this.FindName("SmapleImage")));
            this.Tilte = ((System.Windows.Controls.TextBlock)(this.FindName("Tilte")));
            this.ProgressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("ProgressBar")));
            this.InfoText = ((System.Windows.Controls.TextBlock)(this.FindName("InfoText")));
            this.ProgressText = ((System.Windows.Controls.TextBlock)(this.FindName("ProgressText")));
        }
    }
}

