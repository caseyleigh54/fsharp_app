using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace LearnFSharp
{
    public partial class SingleLessonPage : ContentPage
    {
        List<String> lesson_1 = new List<String>(new String[] { "https://caseyleigh54.github.io/fsharp-quiz/section-1-1.html", "https://caseyleigh54.github.io/fsharp-quiz/section-1-3.html" , "https://caseyleigh54.github.io/fsharp-quiz/section-1-2.html" ,
             "https://caseyleigh54.github.io/fsharp-quiz/section-1-31.html",});
        List<String> lesson_2 = new List<String>(new String[] { "https://caseyleigh54.github.io/fsharp-quiz/section-1-4.html", "https://caseyleigh54.github.io/fsharp-quiz/section-1-5.html" });
        List<String> lesson_3 = new List<String>(new String[] { "https://caseyleigh54.github.io/fsharp-quiz/section-1-6.html" });

        public SingleLessonPage(int lessonNumber, int n)
        {
            InitializeComponent();
            var assembly = Assembly.GetExecutingAssembly();
            string url = "";
            if (lessonNumber == 0)
            {
                url = lesson_1[n-1];
            }
            else if(lessonNumber == 1)
            {
                url = lesson_2[n - 1];

            }
            else if (lessonNumber == 2)
            {
                url = lesson_3[n - 1];

            }
            else
            {
                url = "https://caseyleigh54.github.io/fsharp-quiz/default.html";
            }



            //Stream stream = assembly.GetManifestResourceStream(assembly.GetName().Name + "." + url);
            //if (stream == null)
            //{
            //    throw new InvalidOperationException(
            //        String.Format("Cannot create stream from specified URL: {0}", url));
            //}

            //StreamReader reader = new StreamReader(stream);
            //string htmlString = reader.ReadToEnd();

            //HtmlWebViewSource html = new HtmlWebViewSource();
            //html.Html = htmlString;

            webView.Source = url;
        }
    }
}
