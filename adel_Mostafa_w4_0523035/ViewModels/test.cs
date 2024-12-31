using adel_Mostafa_w4_0523035.Models;

namespace adel_Mostafa_w4_0523035.ViewModels
{
    public class test
    {
        public int p_id { get; set; }
        public Project project { get; set; }
        public int t_id {  get; set; }
        public ICollection<Tasks> tasks { get; set; }
        //public int tem_id {  get; set; }    
        //public TeamMember team { get; set; }
    }
}
