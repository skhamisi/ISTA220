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
        protected int _locX = 0, _locY = 0;
        protected Shape _shape = null;

        public DrawingShape(int size)
        {
            _size = size;
        }

        public void SetLocation(int xCoord, int yCoord)
        {
            _locX = xCoord;
            _locY = yCoord;
        }

        public void SetColor(Color color)
        {
            if(_shape!=null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                _shape.Fill = brush;
            }
        }

        public virtual void Draw(Canvas canvas)
        {
            if(_shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }

            _shape.Height = _size;
            _shape.Width = _size;
            Canvas.SetTop(_shape, _locY);
            Canvas.SetLeft(_shape, _locX);
            canvas.Children.Add(_shape);
        }
    }    
}
