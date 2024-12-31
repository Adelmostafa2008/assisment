using adel_Mostafa_w4_0523035.Models;
using adel_Mostafa_w4_0523035.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace adel_Mostafa_w4_0523035.Controllers
{
    public class TasksController : Controller
    {
        private readonly MyDbContext _context;

        public TasksController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> edit(int id )
        {
            proteam p = new proteam();
            var x = _context.tasks.FirstOrDefault(x => x.Id == id);
            var c = _context.teamMembers.ToList();
            var g = _context.projects.ToList();
            p.teamMembers = c;
            p.projects = g;
            p.tasks = x;
            return View(p);
        }
        [HttpPost]
        public async Task<IActionResult> edit(int id, proteam pr)
        {
            var x = _context.tasks.FirstOrDefault(x => x.Id == id);
            if (x == null)
            {
                return NotFound();
            }
            else
            {
            x.Title = pr.tasks.Title;
            x.Status = pr.tasks.Status;
            x.Priority = pr.tasks.Priority;
            x.Deadline = pr.tasks.Deadline;
                x.p_id = pr.p_id;
                x.tm_id = pr.te_id;
            x.project = (Project?)pr.projects;
            x.teammember = (TeamMember?)pr.teamMembers;
            x.Description = pr.tasks.Description;


            _context.tasks.Update(x);
            await _context.SaveChangesAsync();
            }
            return RedirectToAction("getall" , "Project");
        }
    }
}
