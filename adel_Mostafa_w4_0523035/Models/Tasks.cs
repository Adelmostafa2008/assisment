using Microsoft.CodeAnalysis.Elfie.Extensions;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace adel_Mostafa_w4_0523035.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string ?Title { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        public string ?Status { get; set; }
        public string?Priority {  get; set; }
        public DateTime? Deadline {  get; set; }
        public int ?p_id {  get; set; }
        [ForeignKey("p_id")]
        public Project ?project { get; set; }
        public int ?tm_id {  get; set; }
        [ForeignKey("tm_id")]
        public TeamMember ?teammember { get; set; }
    }
}
