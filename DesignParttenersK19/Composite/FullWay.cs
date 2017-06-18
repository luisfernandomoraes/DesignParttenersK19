using System.Collections.Generic;

namespace DesignParttenersK19.Composite
{
    public class FullWay:IWay
    {
        private List<IWay> _ways;

        public FullWay()
        {
            _ways = new List<IWay>();
        }

        public void Add(IWay way)
        {
            _ways.Add(way);
        }

        public void Remove(IWay way)
        {
            _ways.Remove(way);
        }
        public void Print()
        {
            foreach (var way in _ways)
            {
                way.Print();
            }
        }
    }
}