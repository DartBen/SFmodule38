using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HomeApp.Pages
{
    public class SpanPage : ContentPage
    {
        public SpanPage()
        {
            Label label = new Label()
            {
                FontSize = 16,
                Padding = new Thickness(30, 24, 30, 0),
                FormattedText = new FormattedString()
                {
                    Spans =
                    {
                        new Span() {Text="Learn more at "},
                        new Span() {Text="https://aka.ms/xamarin-quickstart", FontAttributes = FontAttributes.Bold }
                    }
                }

            };
            // Добавление на страницу
            Content = label;
        }
    }
}