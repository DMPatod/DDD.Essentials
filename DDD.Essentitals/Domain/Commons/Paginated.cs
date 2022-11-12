namespace DDD.Essentitals.Domain.Commons
{
    public abstract class Paginated<T>
    {
        private class Metadata
        {
            public int TotalPages { get; set; }
            public int CurrentPage { get; set; }
            public int EntityPerPage { get; set; }
            public int TotalEntities { get; set; }
        }
        public IEnumerable<T> Entities { get; set; } = new List<T>();
    }
}
