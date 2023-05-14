﻿using ShopTerminal.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopTerminal
{
    /// <summary>
    /// Interaction logic for AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }




        private void loginBtnClick(object sender, RoutedEventArgs e)
        {
            //тут авторизация
        }

        private void guestBtnClick(object sender, RoutedEventArgs e)
        {
            //тут просто скипаем и идём смотреть товары
            NavigationService.Navigate(new CatalogPage());
        }
    }
}
