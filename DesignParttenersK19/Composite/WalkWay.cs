using System;

namespace DesignParttenersK19.Composite
{
    public class WalkWay:IWay
    {
        private string _direction;
        private double _distance;
        public WalkWay(string direction, double distance)
        {
            _direction = direction;
            _distance = distance;
        }
        public void Print()
        {
            Console.WriteLine("Go away...");
            Console.WriteLine(_direction);
            Console.WriteLine($"The distance although become: {_distance}");
        }
    }
}