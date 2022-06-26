using System.ComponentModel.DataAnnotations;

namespace FeyzaNurYilmazHafta2WebAPI.DAL.Entity
{
    public class Teacher
    {
        [Key]
        public int TId { get; set; }
        public string TName { get; set; }
        public string TSurname { get; set; }
        public string TMail { get; set; }
        public string TPhone { get; set; }
    }
}
