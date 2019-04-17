using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace LearnFSharp
{
    public partial class SingleLessonPage : ContentPage
    {
        public SingleLessonPage()
        {
            InitializeComponent();
            var assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(assembly.GetName().Name + "." + "TextBox.html");
            if (stream == null)
            {
                throw new InvalidOperationException(
                    String.Format("Cannot create stream from specified URL: {0}", "TextBox.html"));
            }

            StreamReader reader = new StreamReader(stream);
            string htmlString = reader.ReadToEnd();

            HtmlWebViewSource html = new HtmlWebViewSource();
            html.Html = htmlString;

            webView.Source = html;
        }
    }
}
