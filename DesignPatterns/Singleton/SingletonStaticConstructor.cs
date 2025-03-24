namespace DesignPatterns.Singleton
{
    internal class SingletonStaticConstructor
    {
        private static readonly SingletonStaticConstructor _instance;

        static SingletonStaticConstructor()
        {
            _instance = new SingletonStaticConstructor();
        }

        private SingletonStaticConstructor()
        {
        }

        public static SingletonStaticConstructor Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
