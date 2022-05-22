using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnukhinPr11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetData();
        }

        void SetData()
        {
            var rnd = new Random();
            var data = new[] { "Группа: ПКС-31", "ФИО: Енюхин Дмитрий Анатольевич", "Программист со стажем", "Безработный", "В активном поиске",$"Сегодня:{DateTime.Now}"};
            foreach (var text in data)
            {
                var tempLabel = new Label() { HorizontalTextAlignment = TextAlignment.Center, TextColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)), Text = text };
                var tempLabel1 = new Label() { HorizontalTextAlignment = TextAlignment.Center, TextColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)), Text = text };
                stackLayoutVertical.Children.Add(tempLabel);
                stackLayoutHorizontal.Children.Add(tempLabel1);
            }
        }
    }
}
