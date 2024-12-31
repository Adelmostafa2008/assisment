using adel_Mostafa_w4_0523035.Models;
using adel_Mostafa_w4_0523035.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace adel_Mostafa_w4_0523035.Controllers
{
    public class ProjectController : Controller
    {
        private readonly MyDbContext _context;

        public ProjectController(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> getall()
        {
            var x = await _context.projects.ToListAsync();
            return View(x);
        }
        public async Task<IActionResult> details(int id , test t)
        {
            var x = await _context.projects.FirstOrDefaultAsync(x => x.Id == id);
            var c = await _context.tasks.Include(x => x.teammember).Where(x => x.p_id == id).ToListAsync();
            t.project = x;
            t.tasks = c;
            return View(t);
        }
        public async Task<IActionResult> delete(int id)
        {
            var x = _context.projects.FirstOrDefault(x => x.Id == id);
             _context.projects.Remove(x);
            await _context.SaveChangesAsync();
            return RedirectToAction("getall");
        }
        [HttpGet]
        public async Task<IActionResult> add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> add(Project pr)
        {
            await _context.projects.AddAsync(pr);
            await _context.SaveChangesAsync();
            return RedirectToAction("getall");
        }
        [HttpGet]
        public async Task<IActionResult> edit(int id)
        {
            var x = _context.projects.FirstOrDefault(x => x.Id == id);
            return View(x);
        }
        [HttpPost]
        public async Task<IActionResult> edit(int id , Project pr)
        {
            var x = _context.projects.FirstOrDefault(x => x.Id == id);

            x.Name = pr.Name;
            x.Description = pr.Description;
            x.StratDate = pr.StratDate;
            x.EndDate = pr.EndDate;
            
            _context.projects.Update(x);
            await _context.SaveChangesAsync();
            return RedirectToAction("getall");
        }
    }
}
