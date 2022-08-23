namespace singleton_monostate.Patterns
{
    public class MonostatePattern
    {
        private static List<string> Items = new List<string>();

        public MonostatePattern()
        {
        }

        public void AddItems(params string[] items) => Items.AddRange(items);

        public List<string> GetItems => Items;

        public override string ToString()
        {
            return String.Join(Environment.NewLine, Items);
        }
    }
}
