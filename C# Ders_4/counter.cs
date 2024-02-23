
using System.Threading.Channels;

namespace C__Ders_4
{
    internal class Counter
    {
        private int _min { get; set; }
        private int _max { get; set; }
        private int _currentvalue {  get; set; }

        public int _Min
        {
            get { return _min; }

            set 
            {
                if (value >= 0 && value <= 100)
                    _min = value;
                else Console.WriteLine("min in Wrong value");
            }
        }

        public int _Max
        {
            get { return _min; }

            set
            {
                if (value >= 0 && value <= 100)
                    _max = value;
                else Console.WriteLine("max in Wrong value");
            }
        }

        public Counter(int min, int max)
        {
            _Min = min;
            _Max = max;
        }

        public void increment()
        {
            if(_currentvalue != 100)
            {
                if (_currentvalue < _max && _currentvalue != _max)
                    _currentvalue++;

            }
            else if (_currentvalue == 100)
            {
                    _currentvalue = 0;

            }
        }

        public void decrement()
        {
            if (_currentvalue > _min && _currentvalue != _min) 
                _currentvalue--;
        }

        public int Currentvalue()
        {
            return _currentvalue;
        }
    }

}
