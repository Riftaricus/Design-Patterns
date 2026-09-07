using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Displays;

namespace ObserverPattern.Interfaces
{
    public interface Subject
    {
        void RegisterObserver(Display o);
        void RemoveObserver(Display o);
        void NotifyObservers();
    }
}
