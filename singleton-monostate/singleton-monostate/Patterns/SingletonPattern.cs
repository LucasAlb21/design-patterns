namespace singleton_monostate.Patterns
{
    public class SingletonPattern
    {
        private static SingletonPattern _instance;
        private List<string> Items = new List<string>();

        private SingletonPattern()
        {
        }

        public static SingletonPattern GetInstance()
        {
            return _instance ?? (_instance = new SingletonPattern());
        }

        public void AddItems(params string[] items) => Items.AddRange(items);

        public List<string> GetItems => Items;

        public override string ToString()
        {
            return String.Join(Environment.NewLine, Items);
        }
    }
}
