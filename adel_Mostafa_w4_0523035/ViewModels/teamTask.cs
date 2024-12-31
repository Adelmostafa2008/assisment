using adel_Mostafa_w4_0523035.Models;

namespace adel_Mostafa_w4_0523035.ViewModels
{
    public class teamTask
    {
        public int t_id { get; set; }
        public ICollection<Tasks> tasks { get; set; }
        public int team_id { get; set; }
        public TeamMember team_member { get; set; }
    }
}
