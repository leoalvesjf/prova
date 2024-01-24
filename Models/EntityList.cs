namespace ProvaPub.Models
{
    public class EntityList<T>
    {
        public List<T>? Items { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
    }
}
