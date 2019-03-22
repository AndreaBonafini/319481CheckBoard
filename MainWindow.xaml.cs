using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _319481CheckBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {

                    Rectangle r = new Rectangle();
                    r.Height = 15;
                    r.Width = 15;
                  
                    ;
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 ==1 && j % 2 == 1)
                    {
                        r.Fill = Brushes.Coral;
                    }
                    else
                    {
                        r.Fill = Brushes.Silver;
                    }
                    canvas.Children.Add(r);
                    Canvas.SetTop(r, i * 15);
                    Canvas.SetLeft(r, j * 15);
                }
            }



        }
    }
}
