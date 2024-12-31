using adel_Mostafa_w4_0523035.Models;
using adel_Mostafa_w4_0523035.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace adel_Mostafa_w4_0523035.Controllers
{
    public class TeamMemberController : Controller
    {
        private readonly MyDbContext _context;

        public TeamMemberController(MyDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> detailss(int id , teamTask tt)
        {
            var x = await _context.teamMembers.FirstOrDefaultAsync(x => x.Id == id);
            var c = _context.tasks.Where(x => x.tm_id == id).Include(x => x.project).ToList();
            tt.team_member = x;
            tt.tasks = c;
            return View(tt);
        }
        [HttpGet]
        public async Task<IActionResult> edit(int id)
        {
            var x = await _context.teamMembers.FirstOrDefaultAsync(x => x.Id == id);
            return View(x);
        }
        [HttpPost]
        public async Task<IActionResult> edit(int id, TeamMember pr)
        {
            var x = _context.teamMembers.FirstOrDefault(x => x.Id == id);

            x.Name =  pr.Name;
            x.Email = pr.Email;
            x.Role = pr.Role;


            _context.teamMembers.Update(x);
            await _context.SaveChangesAsync();
            return RedirectToAction("getall");
        }
        public async Task<IActionResult> delete (int id)
        {
            var x = _context.teamMembers.FirstOrDefault(x => x.Id == id);
            _context.teamMembers.Remove(x);
            await _context.SaveChangesAsync();
            return RedirectToAction("getall", "Project");
        }
    }
}
