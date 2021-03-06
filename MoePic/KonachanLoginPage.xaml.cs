﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MoePic.Resources;

namespace MoePic
{
    public partial class KonachanLoginPage : Models.MoePicPage
    {
        public KonachanLoginPage()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
        }

        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBar.Opacity = 0.9;
            ApplicationBar.BackgroundColor = (App.Current.Resources["ThemeColor"] as Models.ThemeColor).StatusBar.Color;

            ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/check.png", UriKind.Relative));
            appBarButton.Click += Login_Click;
            appBarButton.Text = AppResources.Login;
            ApplicationBar.Buttons.Add(appBarButton);
            appBarButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/cancel.png", UriKind.Relative));
            appBarButton.Click += Cancel_Click;
            appBarButton.Text = AppResources.Cancel;
            ApplicationBar.Buttons.Add(appBarButton);
        }

        void Cancel_Click(object sender, EventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        async void Login_Click(object sender, EventArgs e)
        {
            if (nowLogining.Visibility == System.Windows.Visibility.Collapsed)
            {
                pro.Focus();
                nowLogining.Visibility = System.Windows.Visibility.Visible;
                bool logined = await MoePic.Models.MoebooruAPI.LoginK(name.Text, password.Password);
                if (logined)
                {
                    MoePic.Models.Settings.Current.UserK = (await MoePic.Models.MoebooruAPI.GetUsersFormName(name.Text, Models.MoebooruAPI.Konachan)).Find((user) => 
                    {
                        if (user.name.ToUpper() == name.Text.ToUpper())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    });
                    MoePic.Models.Settings.Current.UserKHash = MoePic.Models.MoebooruAPI.passwordHashK;
                    ErrorInfo.Visibility = System.Windows.Visibility.Collapsed;
                    NavigationService.GoBack();
                }
                else
                {
                    ErrorInfo.Visibility = System.Windows.Visibility.Visible;
                }
                nowLogining.Visibility = System.Windows.Visibility.Collapsed;
            }
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MoePic.Models.StatusBarService.Init(new Controls.StatusBarView(Controls.Logos.Konachan, MoePic.Resources.AppResources.KLogin, false, true));
            MoePic.Models.StatusBarService.Change(new Controls.StatusBarView(Controls.Logos.Konachan, MoePic.Resources.AppResources.KLogin, false, true));
            base.OnNavigatedTo(e);
        }
    }
}