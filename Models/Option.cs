namespace angular6_dotnet22_example.Models
{
    public class Option
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}