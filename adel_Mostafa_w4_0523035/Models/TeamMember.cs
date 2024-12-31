using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = ServiceStack.DataAnnotations.RequiredAttribute;

namespace adel_Mostafa_w4_0523035.Models
{
    public class TeamMember
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100) , Required]
        public string Name { get; set; }
        [MaxLength(100)]
        [Required]
        [Unique]
        public string Email {  get; set; }
        [MaxLength(50)]
        public string Role { get; set; }
        public int ?t_id {  get; set; }
        public ICollection<Tasks> ?tasks { get; set; }

    }
}
