using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace karusel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var start = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Стартовая страница\nВиды темперамента",
                            TextColor = Color.LightBlue,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
                        },
                    }
                }
            };
            var holerik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Холерик",
                            TextColor = Color.Green,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
                        },
                        new Image {Source = "holerikodin.jpg"}
                    }
                }
            };
            var sangvinik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Сангвиник",
                            TextColor = Color.Orange,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
                        },
                        new Image {Source = "sangvinikodin.jpg"}
                    }
                }
            };
            var flegmatik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Флегматик",
                            TextColor = Color.Purple,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
                        },
                        new Image {Source = "flegmatikodin.jpg"}
                    }
                }
            };
            var melanholik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Меланхолик",
                            TextColor = Color.Chocolate,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
                        },
                        new Image {Source = "melanholikodin.jpg"}
                    }
                }
            };
            Children.Add(start);
            Children.Add(holerik);
            Children.Add(sangvinik);
            Children.Add(flegmatik);
            Children.Add(melanholik);
        }
    }
}
