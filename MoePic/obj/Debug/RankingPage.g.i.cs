﻿#pragma checksum "C:\Users\HIGAN\documents\visual studio 2013\Projects\MoePic\MoePic\RankingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3714CCCBF79CB04BB1777B57594D0F7D"
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
using MoePic.Controls;
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
    
    
    public partial class RankingPage : MoePic.Models.MoePicPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot viewer;
        
        internal MoePic.Controls.PostsViewer day;
        
        internal MoePic.Controls.PostsViewer week;
        
        internal MoePic.Controls.PostsViewer month;
        
        internal MoePic.Controls.PostsViewer year;
        
        internal Microsoft.Phone.Controls.DatePicker date;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MoePic;component/RankingPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.viewer = ((Microsoft.Phone.Controls.Pivot)(this.FindName("viewer")));
            this.day = ((MoePic.Controls.PostsViewer)(this.FindName("day")));
            this.week = ((MoePic.Controls.PostsViewer)(this.FindName("week")));
            this.month = ((MoePic.Controls.PostsViewer)(this.FindName("month")));
            this.year = ((MoePic.Controls.PostsViewer)(this.FindName("year")));
            this.date = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("date")));
        }
    }
}

