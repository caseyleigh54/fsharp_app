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

            SetGesture(basicConcepts, "Basic Concepts");
            SetGesture(loopsConcepts, "Conditionals & Loops");
            SetGesture(methods, "Methods");
            SetGesture(classesAndObjects, "Classes & Objects");
            SetGesture(arraysAndStrings, "Arrays & Strings");
            SetGesture(moreClasses, "More on Classes");





        }
        private void SetGesture(StackLayout stack, string name)
        {
            var tgf = new TapGestureRecognizer();
            tgf.Tapped += (s, e) => OnLabelClicked(name);
            stack.GestureRecognizers.Add(tgf);
        }

        async private void OnLabelClicked(string type)
        { 
            await Navigation.PushAsync(new LessonPage(type));
        }
    }
}
