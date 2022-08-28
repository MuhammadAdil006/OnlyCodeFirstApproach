using OnlyCodeFirstApproach.Models.Interfaces;

namespace OnlyCodeFirstApproach.Models
{
    public class History : IHistory
    {
        public string CreatedBy { get ; set ; }
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ModifiedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ModifiedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
