using System.ComponentModel.DataAnnotations.Schema;
namespace OnlyCodeFirstApproach.Models.Interfaces
{
    public interface IHistory
    {

        public String CreatedBy { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public String ModifiedBy { get; set; }
    }
}
