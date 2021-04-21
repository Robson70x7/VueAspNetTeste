using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Todo.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TodoContext _context;

        public TaskController(TodoContext context)
        {
            _context = context;
        }

        [HttpGet("Create")]
        public async Task<ActionResult> GetAll()
        {
            var tasks = await _context.Task.ToListAsync();
            
            return Ok(tasks);
        }

        [HttpGet("GetTask/{id}")]
        public async Task<ActionResult> GetTask(int id)
        {
            var task = await _context.Task.FirstOrDefaultAsync(t => t.Id == id);

            if(task == null) return NotFound("Task Not Founded");

            return  Ok(task);
            
        }

    }
}