﻿#pragma checksum "C:\Users\HIGAN\documents\visual studio 2013\Projects\MoePic\MoePic\AboutPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7D448F6628ED03A685D321C68A7DCC48"
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
    
    
    public partial class AboutPage : MoePic.Models.MoePicPage {
        
        internal MoePic.Models.MoePicPage phoneApplicationPage;
        
        internal System.Windows.Media.Animation.Storyboard LogoAnime;
        
        internal System.Windows.Media.Animation.Storyboard PulsAnime;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Path path;
        
        internal System.Windows.Shapes.Path path1;
        
        internal System.Windows.Shapes.Path path2;
        
        internal System.Windows.Shapes.Path path3;
        
        internal System.Windows.Shapes.Rectangle rectangle;
        
        internal System.Windows.Shapes.Rectangle rectangle1;
        
        internal System.Windows.Controls.TextBlock VersionText;
        
        internal System.Windows.Controls.Button getLongTrial;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MoePic;component/AboutPage.xaml", System.UriKind.Relative));
            this.phoneApplicationPage = ((MoePic.Models.MoePicPage)(this.FindName("phoneApplicationPage")));
            this.LogoAnime = ((System.Windows.Media.Animation.Storyboard)(this.FindName("LogoAnime")));
            this.PulsAnime = ((System.Windows.Media.Animation.Storyboard)(this.FindName("PulsAnime")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.path = ((System.Windows.Shapes.Path)(this.FindName("path")));
            this.path1 = ((System.Windows.Shapes.Path)(this.FindName("path1")));
            this.path2 = ((System.Windows.Shapes.Path)(this.FindName("path2")));
            this.path3 = ((System.Windows.Shapes.Path)(this.FindName("path3")));
            this.rectangle = ((System.Windows.Shapes.Rectangle)(this.FindName("rectangle")));
            this.rectangle1 = ((System.Windows.Shapes.Rectangle)(this.FindName("rectangle1")));
            this.VersionText = ((System.Windows.Controls.TextBlock)(this.FindName("VersionText")));
            this.getLongTrial = ((System.Windows.Controls.Button)(this.FindName("getLongTrial")));
        }
    }
}

