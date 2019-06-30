using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace LearnFSharp
{
    public partial class LessonPage : ContentPage
    {
        public ICommand LessonSelectedCommand { get; set; }
        List<String> titleList = new List<String> ( new string[] {"Basic Concepts", "Programming Styles", "Lists", "Classes & Objects", "Arrays & Strings", "More on Classes" });
        List<int> numLessons = new List<int>(new int[] { 4, 2, 1 });
        List<String> lesson1Titles = new List<String>(new string[] { "What is F#?", "Getting Started", "Writing Code in F#", "Inference"});
        List<String> lesson1Nav = new List<String>(new string[] { "1/6", "1/1", "1/6", "1/5" });
        List<String> lesson1Questions = new List<String>(new string[] { "2", "0", "1", "2" });

        List<String> lesson2Titles = new List<String>(new string[] { "Two Programming Styles", "Execution Model" });
        List<String> lesson2Nav = new List<String>(new string[] { "1/8", "1/7"});
        List<String> lesson2Questions = new List<String>(new string[] { "0", "1"});

        List<String> lesson3Titles = new List<String>(new string[] { "Lists"});
        List<String> lesson3Nav = new List<String>(new string[] { "1/8" });
        List<String> lesson3Questions = new List<String>(new string[] { "0" });

        List<String> lessonTitles = new List<String>(new string[] { "Empty" });
        List<String> lessonNav = new List<String>(new string[] { "0/0" });
        List<String> lessonQuestions = new List<String>(new string[] { "0" });


        int lessonNumber;
        public LessonPage(int lessonN)
        {
            NavigationPage.SetBackButtonTitle(this, "");
            InitializeComponent();
            lessonNumber = lessonN;
            this.Title = titleList[lessonNumber];
            int numViews = numLessons[lessonNumber];

            switch (lessonNumber)
            {
                case 0:
                    lessonTitles = lesson1Titles;
                    lessonNav = lesson1Nav;
                    lessonQuestions = lesson1Questions;
                    break;
                case 1:
                    lessonTitles = lesson2Titles;
                    lessonNav = lesson2Nav;
                    lessonQuestions = lesson2Questions;
                    break;
                case 2:
                    lessonTitles = lesson3Titles;
                    lessonNav = lesson3Nav;
                    lessonQuestions = lesson3Questions;
                    break;
                default:
                    break;

            }

            var grid = new Grid
            {
                RowSpacing = 10,
                ColumnSpacing = 10
            };

            int row = 0;
            int col = 0;

            for(int i =1; i<=numViews; i++)
            {

                grid.RowDefinitions.Add(new RowDefinition
                {
                    Height = 185
                });
                LessonGridView v = new LessonGridView { Title = lessonTitles[i-1], Questions = lessonQuestions[i-1] + " question(s)", Nav = lessonNav[i-1] };
                grid.Children.Add(v, col, row);
                SetGesture(v, i);

                if(col == 0)
                {
                    col += 1;
                }else if(col == 1 )
                {
                    row += 1;
                    col = 0;
                }

            }



            //SetGesture(grid1, 1);
            //SetGesture(grid2, 2);
            //SetGesture(grid3, 3);
            //SetGesture(grid4, 4);
            //SetGesture(grid5, 5);
            //SetGesture(grid6, 6);
            //SetGesture(grid7, 7);
            //SetGesture(grid8, 8);
            //SetGesture(grid9, 9);
            stackLayout.Children.Add(grid);
        }

        private void SetGesture(LessonGridView gridItem, int n)
        {
            var tgf = new TapGestureRecognizer();
            tgf.Tapped += (s, e) => OnLabelClicked(n);
            gridItem.GestureRecognizers.Add(tgf);
        }

        async private void OnLabelClicked(int n)
        {

            await Navigation.PushAsync(new SingleLessonPage(lessonNumber, n));
        }
    }
}
