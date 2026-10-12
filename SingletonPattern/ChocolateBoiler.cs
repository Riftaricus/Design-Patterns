using System.Runtime.CompilerServices;

namespace Singleton
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }

        private static readonly Lazy<ChocolateBoiler> instance = new();

        public static ChocolateBoiler GetInstance() => instance.Value;

        private readonly object stateLock = new();

        public void Fill()
        {
            lock (stateLock)
            {
                if (empty)
                {
                    empty = false;
                    boiled = false;
                }
            }
        }
        // To drain the boiler, it must be full (non empty) and also boiled.
        // Once it is drained we set empty back to true
        public void Drain()
        {
            lock (stateLock)
            {
                if (!empty && boiled)
                {
                    empty = true;
                }
            }

        }
        // To boil the mixture, the boiler has to be full and not already boiled.
        // Once it is boiled we set the boiled flag to true
        public void Boil()
        {
            lock (stateLock)
            {
                if (!empty && !boiled)
                {
                    boiled = true;
                }
            }
        }

        public override String ToString()
        {
            return $"empty? {IsEmpty} boiled? {IsBoiled}";
        }
    }
}
