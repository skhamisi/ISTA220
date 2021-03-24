using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;


namespace Drawing
{
    class Square : DrawingShape, IDraw, IColor
    {
        public Square(int sideLength) : base(sideLength)
        {
        }

        public override void Draw(Canvas canvas)
        {
            if (_shape != null)
            {
                canvas.Children.Remove(_shape);
            }
            else
            {
                _shape = new Rectangle();
            }

            base.Draw(canvas);
        }
    }
}
