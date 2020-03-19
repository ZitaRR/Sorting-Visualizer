using SortingVisualizer.ViewModels;
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

namespace SortingVisualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private Random random = new Random();
        //private int[] arrays;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ArrayVisualizerViewModel(Canvas);
            //arrays = new int[random.Next(50, 80)];
            //AddLines(arrays.Length);
        }

        //private void AddLines(int amount)
        //{
        //    for (int i = 0; i < amount; i++)
        //    {
        //        int length = random.Next(50, 200);
        //        arrays[i] = length;
        //
        //        Line line = new Line();
        //        line.Stroke = Brushes.White;
        //        line.X1 = i == 0 ? 1 : i * 4;
        //        line.X2 = line.X1;
        //        line.Y1 = 0;
        //        line.Y2 = length;
        //        line.HorizontalAlignment = HorizontalAlignment.Left;
        //        line.VerticalAlignment = VerticalAlignment.Center;
        //        line.StrokeThickness = 2;
        //        Canvas.Children.Add(line);
        //    }
        //}
    }
}
