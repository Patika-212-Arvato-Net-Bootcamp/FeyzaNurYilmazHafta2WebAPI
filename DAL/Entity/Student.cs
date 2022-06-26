using System.ComponentModel.DataAnnotations;

namespace FeyzaNurYilmazHafta2WebAPI.DAL.Entity
{
    public class Student
    {
        [Key]
        public int SId { get; set; }
        public string SName { get; set; }
        public string SSurname { get; set; }
        public string SMail { get; set; }
        public string SPhone { get; set; }
    }
}
