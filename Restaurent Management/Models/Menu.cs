using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hotel.Web.Models
{
    [Table(name: "Menu")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DishID { get; set; }

        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Customer Name Should be min 5 and max 20 length")]
        [Display(Name = "Name of the Dish")]
        public string DishName { get; set; }

        [Required]
        [DefaultValue(1)]
        virtual public short Quantity { get; set; }


        


        [Required(ErrorMessage = "{0} cannot be empty!")]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Price")]
        public string DishPrice { get; set; }



        #region Navigation Properties to the Category Model
        [Display(Name = "Choose Category")]
        public int CategoryId { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        [ForeignKey(nameof(Menu.CategoryId))]
        public Category Category { get; set; }
        #endregion


        #region Navigation Properties to the OrderDetails Model
        public ICollection<OrderDetails> OrderDetails { get; set; }
        #endregion
    }
}