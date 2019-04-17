using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LearnFSharp
{
    public partial class MultipleChoice : ContentView
    {

        public static readonly BindableProperty isVisibleProperty = BindableProperty.Create("isVisible", typeof(string), typeof(LessonGridView));
        public string isVisible
        {
            get { return (string)GetValue(isVisibleProperty); }
            set { SetValue(isVisibleProperty, value); }
        }

        public static readonly BindableProperty QuestionProperty = BindableProperty.Create("Question", typeof(string), typeof(LessonGridView));
        public string Question
        {
            get { return (string)GetValue(QuestionProperty); }
            set { SetValue(QuestionProperty, value); }
        }

        public static readonly BindableProperty Q1Property = BindableProperty.Create("Q1", typeof(string), typeof(LessonGridView));
        public string Q1
        {
            get { return (string)GetValue(Q1Property); }
            set { SetValue(Q1Property, value); }
        }

        public static readonly BindableProperty Q2Property = BindableProperty.Create("Q2", typeof(string), typeof(LessonGridView));
        public string Q2
        {
            get { return (string)GetValue(Q2Property); }
            set { SetValue(Q2Property, value); }
        }

        public static readonly BindableProperty Q3Property = BindableProperty.Create("Q3", typeof(string), typeof(LessonGridView));
        public string Q3
        {
            get { return (string)GetValue(Q3Property); }
            set { SetValue(Q3Property, value); }
        }

        public static readonly BindableProperty Q4Property = BindableProperty.Create("Q4", typeof(string), typeof(LessonGridView));
        public string Q4
        {
            get { return (string)GetValue(Q4Property); }
            set { SetValue(Q4Property, value); }
        }


        public MultipleChoice()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
