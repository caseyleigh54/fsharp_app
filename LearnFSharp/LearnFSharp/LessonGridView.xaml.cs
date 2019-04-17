using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LearnFSharp
{
    public partial class LessonGridView : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(LessonGridView));
        public string Title {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); } 
        }

        public static readonly BindableProperty NavProperty = BindableProperty.Create("Nav", typeof(string), typeof(LessonGridView));
        public string Nav
        {
            get { return (string)GetValue(NavProperty); }
            set { SetValue(NavProperty, value); }
        }

        public static readonly BindableProperty QuestionsProperty = BindableProperty.Create("Questions", typeof(string), typeof(LessonGridView));
        public string Questions
        {
            get { return (string)GetValue(QuestionsProperty); }
            set { SetValue(QuestionsProperty, value); }
        }

        public LessonGridView()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
