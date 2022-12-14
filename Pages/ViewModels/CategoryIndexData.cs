using budnar_pavel_lab2.Models;

namespace budnar_pavel_lab2.Pages.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<BookCategory> BookCategories { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
