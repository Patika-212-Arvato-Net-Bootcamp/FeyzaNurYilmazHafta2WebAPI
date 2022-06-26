using System.ComponentModel.DataAnnotations;

namespace FeyzaNurYilmazHafta2WebAPI.DAL.Entity
{
    public class Teacher_Bootcamp
    {
        [Key]
        public int TId { get; set; }
        public int BId { get; set; }
    }
}
