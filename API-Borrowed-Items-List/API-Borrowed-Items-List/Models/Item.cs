using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace API_Borrowed_Items_List.Models
{
    public class Item
    {
        [Key]  // primary key
        public int Id { get; set; }  // id of the item
        public string Borrower { get; set; }
        public string Lender { get; set; }
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
    }
}
