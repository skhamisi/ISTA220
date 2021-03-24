using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Drawing
{
    abstract class DrawingShape
    {
        protected int _size;
        protected int _x = 0; 
        protected int _y = 0;
        protected Shape shape = null;

        public DrawingShape(int s)
        {
            _size = s;
        }

        public int X
        {
            get {return _x;}
            set {_x = value;}
        }

        public int Y
        {
            get {return _y;}
            set {_y = value;}
        }
               

        public Color Color
        {
            set
            {
                if (shape != null)
                {
                    SolidColorBrush brush = new SolidColorBrush(value);
                    shape.Fill = brush;
                }
            }
        }
                
        public virtual void Draw(Canvas canvas)
        {
            if(shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }

            shape.Height = _size;
            shape.Width = _size;
            Canvas.SetTop(shape, _y);
            Canvas.SetLeft(shape, _x);
            canvas.Children.Add(shape);
        }
    }    
}
