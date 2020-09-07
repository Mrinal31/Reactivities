using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            var value = await _context.Values.ToListAsync();
            return Ok(value);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {

            var value = await _context.Values.FindAsync(id);
            return Ok(value);
        }
    }
}