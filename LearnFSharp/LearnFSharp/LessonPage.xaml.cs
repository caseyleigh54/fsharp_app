using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace LearnFSharp
{
    public partial class LessonPage : ContentPage
    {
        public ICommand LessonSelectedCommand { get; set; }
        public LessonPage(string lessonName)
        {
            NavigationPage.SetBackButtonTitle(this, "");
            InitializeComponent();
            this.Title = lessonName;

            var tgf = new TapGestureRecognizer();
            tgf.Tapped += (s, e) => OnLabelClicked();
            grid1.GestureRecognizers.Add(tgf);




        }

        async private void OnLabelClicked()
        {

            await Navigation.PushAsync(new SingleLessonPage());
        }
    }
}
