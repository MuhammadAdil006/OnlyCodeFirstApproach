using OnlyCodeFirstApproach.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlyCodeFirstApproach.Models
{
    public class Item:IHistory
    {
        public int Id { get; set; } //add auto increament and make it primary key ? how to add
        public String  Name { get; set; }
        public int  Price { get; set; }
        public String?  Description { get; set; }
        [Column(TypeName = "varchar(30)")]
        public String Color { get; set; }
        public string CreatedBy { get; set; } = "";
        public DateTime CreatedAt { get; set ; }
        public DateTime ModifiedAt { get ; set; }
        public string ModifiedBy { get; set; } = "";
    }
}
