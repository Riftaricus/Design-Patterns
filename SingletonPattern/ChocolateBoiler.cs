using System.Runtime.CompilerServices;

namespace Singleton
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }

        private static readonly object _balanceLock = new();
        private static ChocolateBoiler? boilerInstance;
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        // [MethodImpl(MethodImplOptions.Synchronized)]
        public static ChocolateBoiler GetInstance()
        {
            if (boilerInstance == null)
            {
                lock (_balanceLock)
                {
                    if (boilerInstance == null)
                    {
                        boilerInstance = new ChocolateBoiler();
                    }
                }
            }
            return boilerInstance;
        }

        // To fill the boiler it must be empty and once it is full, we set the empty and boiled flag
        public void fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
            }
        }
        // To drain the boiler, it must be full (non empty) and also boiled.
        // Once it is drained we set empty back to true
        public void drain()
        {
            if (!empty && boiled)
            {
                empty = true;
            }
        }
        // To boil the mixture, the boiler has to be full and not already boiled.
        // Once it is boiled we set the boiled flag to true
        public void boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
            }
        }

        public override String ToString()
        {
            return $"empty? {IsEmpty} boiled? {IsBoiled}";
        }
    }
}
