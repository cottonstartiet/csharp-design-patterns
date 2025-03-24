namespace DesignPatterns.Singleton
{
    internal class SingletonEager
    {
        private static readonly SingletonEager _instance = new SingletonEager();

        private SingletonEager()
        {
        }

        public static SingletonEager Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
