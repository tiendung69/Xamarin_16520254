﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Thông báo", "Bạn đã đăng nhập thành công", "Thoát");
        }
    }
}