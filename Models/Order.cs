namespace angular6_dotnet22_example.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }
        public bool IsFollowToNewsletter { get; set; }
    }
}