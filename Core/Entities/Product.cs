namespace Core.Entities
{
    public class Product
    {
        public Product(int id, string name)
        {
            this.Id = id;
            this.Name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}