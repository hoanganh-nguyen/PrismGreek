using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismGeek.Tests.DesignPattern
{
    public class Stock
    {
        public int Price { get; set; }

    }

    public class StockObservable : IObservable<Stock>
    {

        List<IObserver<Stock>> _observers;
        public StockObservable()
        {
            _observers = new List<IObserver<Stock>>();
        }

        private Stock _stock;
        public Stock Stock
        {
            get { return _stock; }
            set
            {
                _stock = value;
                Notify();
            }
        }
        public IDisposable Subscribe(IObserver<Stock> observer)
        {
            if(!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber(_observers, observer);
        }

        private void Notify()
        {
            
        }
    }

    public class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<Stock>> _observers;
        private readonly IObserver<Stock> _observer;

        public Unsubscriber(List<IObserver<Stock>> observers, IObserver<Stock> observer)
        {
            _observers = observers;
            _observer = observer;
        }
        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
