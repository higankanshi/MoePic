﻿#pragma checksum "C:\Users\HIGAN\documents\visual studio 2013\Projects\MoePic\MoePic\Controls\TagItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "332F4F6D848735A49FD68766C0AEA9BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MoePic.Controls;
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
    
    
    public partial class TagItem : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl userControl;
        
        internal System.Windows.Media.Animation.Storyboard ButtonsOut;
        
        internal System.Windows.Media.Animation.Storyboard ButtonsIn;
        
        internal System.Windows.Media.Animation.Storyboard ShowButton;
        
        internal System.Windows.Media.Animation.EasingDoubleKeyFrame ShowButtonKeyFrame1;
        
        internal System.Windows.Media.Animation.EasingDoubleKeyFrame ShowButtonKeyFrame2;
        
        internal System.Windows.Media.Animation.Storyboard HideButton;
        
        internal System.Windows.Media.Animation.SplineDoubleKeyFrame HideButtonKeyFrame1;
        
        internal System.Windows.Media.Animation.SplineDoubleKeyFrame HideButtonKeyFrame2;
        
        internal System.Windows.Media.Animation.Storyboard TagItemLoaded;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel tagContent;
        
        internal System.Windows.Controls.Grid grid;
        
        internal MoePic.Controls.ColorfulButton colorfulButton1;
        
        internal MoePic.Controls.ColorfulButton colorfulButton2;
        
        internal MoePic.Controls.ColorfulButton colorfulButton3;
        
        internal MoePic.Controls.ColorfulButton colorfulButton4;
        
        internal MoePic.Controls.ColorfulButton colorfulButton;
        
        internal System.Windows.Controls.TextBlock TagName;
        
        internal System.Windows.Controls.TextBlock TagText;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MoePic;component/Controls/TagItem.xaml", System.UriKind.Relative));
            this.userControl = ((System.Windows.Controls.UserControl)(this.FindName("userControl")));
            this.ButtonsOut = ((System.Windows.Media.Animation.Storyboard)(this.FindName("ButtonsOut")));
            this.ButtonsIn = ((System.Windows.Media.Animation.Storyboard)(this.FindName("ButtonsIn")));
            this.ShowButton = ((System.Windows.Media.Animation.Storyboard)(this.FindName("ShowButton")));
            this.ShowButtonKeyFrame1 = ((System.Windows.Media.Animation.EasingDoubleKeyFrame)(this.FindName("ShowButtonKeyFrame1")));
            this.ShowButtonKeyFrame2 = ((System.Windows.Media.Animation.EasingDoubleKeyFrame)(this.FindName("ShowButtonKeyFrame2")));
            this.HideButton = ((System.Windows.Media.Animation.Storyboard)(this.FindName("HideButton")));
            this.HideButtonKeyFrame1 = ((System.Windows.Media.Animation.SplineDoubleKeyFrame)(this.FindName("HideButtonKeyFrame1")));
            this.HideButtonKeyFrame2 = ((System.Windows.Media.Animation.SplineDoubleKeyFrame)(this.FindName("HideButtonKeyFrame2")));
            this.TagItemLoaded = ((System.Windows.Media.Animation.Storyboard)(this.FindName("TagItemLoaded")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.tagContent = ((System.Windows.Controls.StackPanel)(this.FindName("tagContent")));
            this.grid = ((System.Windows.Controls.Grid)(this.FindName("grid")));
            this.colorfulButton1 = ((MoePic.Controls.ColorfulButton)(this.FindName("colorfulButton1")));
            this.colorfulButton2 = ((MoePic.Controls.ColorfulButton)(this.FindName("colorfulButton2")));
            this.colorfulButton3 = ((MoePic.Controls.ColorfulButton)(this.FindName("colorfulButton3")));
            this.colorfulButton4 = ((MoePic.Controls.ColorfulButton)(this.FindName("colorfulButton4")));
            this.colorfulButton = ((MoePic.Controls.ColorfulButton)(this.FindName("colorfulButton")));
            this.TagName = ((System.Windows.Controls.TextBlock)(this.FindName("TagName")));
            this.TagText = ((System.Windows.Controls.TextBlock)(this.FindName("TagText")));
        }
    }
}

