using System.ComponentModel.DataAnnotations;

namespace FeyzaNurYilmazHafta2WebAPI.DAL.Entity
{
    public class Bootcamp
    {
        [Key]
        public int BId { get; set; }
        public string BName { get; set; }
        public DateTime BDeadlineApp { get; set; }
        public DateTime BStartDate { get; set; }
        public DateTime BEndDate { get; set; }
        public string BCompany { get; set; }
        public string BSubject { get; set; }
        public string BDescription { get; set; }
        public string BLocation { get; set; }
        public int Price { get; set; }
    }
}
