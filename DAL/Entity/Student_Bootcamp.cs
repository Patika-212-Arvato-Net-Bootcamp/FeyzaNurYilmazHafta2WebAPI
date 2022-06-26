using System.ComponentModel.DataAnnotations;

namespace FeyzaNurYilmazHafta2WebAPI.DAL.Entity
{
    public class Student_Bootcamp
    {
        [Key]
        public int SId { get; set; }
        public int BId { get; set; }
    }
}
