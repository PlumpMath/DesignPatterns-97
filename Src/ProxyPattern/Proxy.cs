namespace ProxyPattern
{
    public interface IMath<T>
    {
        T Add(T x, T y);
        T Subtract(T x, T y);
        T Multibly(T x, T y);
        T Divide(T x, T y);

    }

    class Math<T> : IMath<T>
    {
        public T Add(T x, T y)
        {
            dynamic no1 = x;
            dynamic no2 = y;
            return no1 + no2;
        }

        public T Subtract(T x, T y)
        {
            dynamic no1 = x;
            dynamic no2 = y;
            return no1 - no2;
        }

        public T Multibly(T x, T y)
        {
            dynamic no1 = x;
            dynamic no2 = y;
            return no1 * no2;
        }

        public T Divide(T x, T y)
        {
            dynamic no1 = x;
            dynamic no2 = y;
            return no1 / no2;
        }
    }

    public class Proxy<T> : IMath<T>
    {
        private readonly Math<T> _math = new Math<T>();

        public T Add(T x, T y)
        {
            return _math.Add(x, y);
        }

        public T Subtract(T x, T y)
        {
            return _math.Subtract(x, y);
        }

        public T Multibly(T x, T y)
        {
            return _math.Multibly(x, y);
        }

        public T Divide(T x, T y)
        {
            return _math.Divide(x, y);
        }
    }
}