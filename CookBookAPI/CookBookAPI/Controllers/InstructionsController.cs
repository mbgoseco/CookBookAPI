using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBookAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CookBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructionsController : ControllerBase
    {
        private readonly CookBookDbContext _context;

        public InstructionsController(CookBookDbContext context)
        {
            _context = context;
        }

        // GET

        // POST

        // PUT

        // DELETE
    }
}