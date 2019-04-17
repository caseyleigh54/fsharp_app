using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LearnFSharp
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");

            menuList = new List<MasterPageItem>();

            var page1 = new MasterPageItem() { Title = "Home", Icon = "home.png", TargetType = typeof(SectionsPage) };
            var page2 = new MasterPageItem() { Title = "Code Playground", Icon = "curly-brackets.png", TargetType = typeof(CodePlayground) };

            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);



            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;





            }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page))
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.FromHex("#00bcd4"),
            };
            IsPresented = false;
        }

    }
}
