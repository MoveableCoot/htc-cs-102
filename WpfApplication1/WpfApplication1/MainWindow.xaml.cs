using Shapes;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rectangle myRect = new Rectangle();
            myRect.Height = 100;
            myRect.Width = 100;
            myRect.Fill = Brushes.Red;
            myRect.Stroke = Brushes.Black;
            myRect.StrokeThickness = 2;

            Canvas.SetLeft(myRect, 100);
            Canvas.SetTop(myRect, 100);
            myCanvas.Children.Add(myRect);


            Diamond myDiam = new Diamond();
            myDiam.Height = 50;
            myDiam.Width = 50;
            myDiam.Fill = Brushes.Blue;
            myDiam.Stroke = Brushes.Orange;
            myDiam.StrokeThickness = 7;

            Canvas.SetLeft(myDiam, 300);
            Canvas.SetTop(myDiam, 300);
            myCanvas.Children.Add(myDiam);

            Triangle myTri = new Triangle();
            myTri.Height = 150;
            myTri.Width = 150;
            myTri.Fill = Brushes.Black;
            myTri.Stroke = Brushes.Blue;
            myTri.StrokeThickness = 7;

            Canvas.SetLeft(myDiam, 200);
            Canvas.SetTop(myDiam, 200);
            myCanvas.Children.Add(myTri);
        }
    }
}
