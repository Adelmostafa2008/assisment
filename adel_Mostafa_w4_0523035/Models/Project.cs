using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace adel_Mostafa_w4_0523035.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public DateTime StratDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ? t_id {  get; set; }
        [ForeignKey("t_id")]
        public ICollection<Tasks> ?tasks { get; set; }
    }
}
