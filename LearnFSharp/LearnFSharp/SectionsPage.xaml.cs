using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LearnFSharp
{
    public partial class SectionsPage : ContentPage
    {
        public SectionsPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            basicImage.Source = ImageSource.FromFile("curly.png");
            loopsImage.Source = ImageSource.FromFile("infinity.png");
            methodsImage.Source = ImageSource.FromFile("settings.png");
            classesImage.Source = ImageSource.FromFile("structure.png");
            arraysImage.Source = ImageSource.FromFile("threeD.png");
            moreClassesImage.Source = ImageSource.FromFile("organization.png");

            SetGesture(basicConcepts, 0);
            SetGesture(programmingStyles, 1);
            SetGesture(lists, 2);
            //SetGesture(classesAndObjects, 3);
            //SetGesture(arraysAndStrings, 4);
            //SetGesture(moreClasses, 5);





        }
        private void SetGesture(StackLayout stack, int name)
        {
            var tgf = new TapGestureRecognizer();
            tgf.Tapped += (s, e) => OnLabelClicked(name);
            stack.GestureRecognizers.Add(tgf);
        }

        async private void OnLabelClicked(int type)
        { 
            await Navigation.PushAsync(new LessonPage(type));
        }
    }
}
