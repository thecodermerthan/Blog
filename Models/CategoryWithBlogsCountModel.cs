namespace BlogFront.Models{
    public class CategoryWithBlogsCountModel{
        public int BlogsCount { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}