using System.ComponentModel.DataAnnotations;

namespace API_Borrowed_Items_List.Models
{
    public class Item
    {
        [Key]  // primary key
        public int Id { get; set; }  // id of the item
        public string Borrower { get; set; }
    }
}
