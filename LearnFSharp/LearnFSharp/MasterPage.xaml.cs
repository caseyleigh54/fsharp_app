using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LearnFSharp
{
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("user.png");
            //homeImage.Source = ImageSource.FromFile("home.png");
            List<MenuItemClass>_menuList = new List<MenuItemClass>
            {
                new MenuItemClass {Name = "Home", ImageUrl="home.png"},
                new MenuItemClass {Name = "Code Playground", ImageUrl="curly-brackets.png"}
            };
            listView.ItemsSource = _menuList;

            


        }

        async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            if (e.ItemIndex != 0)
            {
                listView.SelectedItem = null;


            }
            if(e.ItemIndex == 1)
            {


            }
            
        }
    }
}
