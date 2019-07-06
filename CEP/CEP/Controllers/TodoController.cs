using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CEP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CEP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly Context _context;

        public TodoController(Context context)
        {
            _context = context;

            if (_context.endereco.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.endereco.Add(new Endereco { cep = "Item1" });
                _context.SaveChanges();
            }
        }
    }
}