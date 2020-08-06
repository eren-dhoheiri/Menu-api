namespace Menu.Models
{

    public class MenuItem
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Parent { get; set; }
        public string Path { get; set; }
    }
}