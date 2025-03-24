namespace DesignPatterns.Singleton
{
    internal class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> _instance = new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy()
        {
        }

        public static SingletonLazy Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
