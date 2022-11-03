using Northwind.Mvc.Models.Entity;

namespace Northwind.Mvc.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel(int visitorCount, List<Category> categories, List<Product> products)
        {
            VisitorCount = visitorCount;
            Categories = categories;
            Products = products;
        }

        public int VisitorCount { get; set; }
        public List<Category> Categories { get; set; }

        public List<Product> Products { get; set; }

    }
}
