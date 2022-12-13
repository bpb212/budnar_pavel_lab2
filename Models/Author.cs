using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace budnar_pavel_lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+")]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-Z][a-z]+")]
        public string LastName { get; set; }
    }
}
