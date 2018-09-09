namespace apitest1.Onion.Domain.Models
{
    public class Category
    {
        public string Name { get; set; } = "John";
        public string Page { get; set; } = "Default count";
        private string PrivateName { get; set; } = "Private Name";
    }
}