using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Hotel.Web.Models
{
    [Table(name: "DishCategory")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }


        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Customer Name Should be min 5 and max 20 length")]
        [Display(Name = "Name of the Category")]

        public string CategoryName { get; set; }

        #region Navigation Properties to the Menu Model

        public ICollection<Menu> Menu { get; set; }
        

        #endregion


    }
}