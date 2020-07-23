using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    private readonly DataContext _context;
    public ValuesController(DataContext context)
    {
      _context = context;
    }

    // GET api/values
    [HttpGet]
    public async Task<IActionResult> GetValues()
    {
      // DbSet
      var values = await _context.Values.ToListAsync();

      return Ok(values);
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetValue(int id)
    {
      // DbSet
      var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

      return Ok(value);
    }



  }
}