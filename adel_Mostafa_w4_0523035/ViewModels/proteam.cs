using adel_Mostafa_w4_0523035.Models;

namespace adel_Mostafa_w4_0523035.ViewModels
{
    public class proteam
    {
        public int p_id {  get; set; }
        public ICollection<Project> projects { get; set; }
        public int te_id {  get; set; }
        public ICollection<TeamMember> teamMembers { get; set; }
        public int t_id {  get; set; }
        public Tasks tasks { get; set; }
    }
}
