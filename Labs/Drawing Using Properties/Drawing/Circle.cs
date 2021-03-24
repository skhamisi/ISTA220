﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Circle : DrawingShape, IDraw, IColor
    {
        public Circle(int diameter):base(diameter)
        {            
        }

        public override void Draw(Canvas canvas)
        {
            if(shape!=null)
            {
                canvas.Children.Remove(shape);
            }
            else
            {
                shape = new Ellipse();
            }

            base.Draw(canvas);
        }
    }
}
