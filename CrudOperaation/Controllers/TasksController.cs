using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class TasksController : Controller
{
    private readonly AppDbContext _context;

    public TasksController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(string search)
    {
        var tasks = from t in _context.Tasks select t;

        if (!string.IsNullOrEmpty(search))
        {
            tasks = tasks.Where(t => t.TaskTitle.Contains(search));
        }

        return View(await tasks.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(TaskItem task)
    {
        if (ModelState.IsValid)
        {
            _context.Add(task);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(task);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var task = await _context.Tasks.FindAsync(id);
        return View(task);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(TaskItem task)
    {
        task.LastUpdatedOn = DateTime.Now;
        _context.Update(task);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        var task = await _context.Tasks.FindAsync(id);
        return View(task);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var task = await _context.Tasks.FindAsync(id);
        _context.Tasks.Remove(task!);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
            return NotFound();

        var task = await _context.Tasks
            .FirstOrDefaultAsync(m => m.Id == id);

        if (task == null)
            return NotFound();

        return View(task);
    }
}
