using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SortingVisualizer.Models
{
    internal class ValueModel
    {
        private Canvas canvas;
        private int id;

        public int Id
        {
            get => id;
            set
            {
                id = value;
                DrawLine();
            }
        }
        public int Value { get; private set; }
        public Line Line { get; private set; }

        public ValueModel(Canvas canvas, int id)
        {
            this.canvas = canvas;
            this.id = id;
            
            Line = new Line
            {
                Stroke = Brushes.White,
                StrokeThickness = 3,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center
            };
            
            canvas.Children.Add(Line);
            RandomizeValue();
        }

        public void RandomizeValue()
        {
            Value = new Random().Next(40, 300);
            DrawLine();
        }

        internal void DrawLine()
        {
            Line.X1 = Id == 0 ? 1 : Id * 7;
            Line.X2 = Line.X1;
            Line.Y1 = 0;
            Line.Y2 = Value;
        }
    }
}
