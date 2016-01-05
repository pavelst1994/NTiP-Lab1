namespace Core
{
    public class Pyramid : IFigure
    {
        private int _square;
        private int _heigth;
        public Pyramid(int square, int heigth)
        {
            if ((square <= 0) || (heigth <= 0))
            {
                throw new ShapeExeption("Значение площади и высоты пирамиды должны быть положительными");
            }

            _square = square;
            _heigth = heigth;//проверка
        }
        public double ReturnVolume()
        {
            return 1 / 3.0 * _square * _heigth;
        }
    }
}
