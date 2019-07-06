using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CEP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CEP.Controllers
{
    [Route("api/Endereco")]
    [ApiController]

        public class ToDoController : ControllerBase
        {
            private readonly Context _context;

            public ToDoController(Context context)
            {
                _context = context;
            }

            [HttpGet("Enderecos")]
            public IEnumerable<Endereco> MostraTudo()
            {
                List<Endereco> enderecos = _context.endereco.ToList();
                return enderecos;
            }

            [HttpGet("Enderecos/{cep}")]
            public IEnumerable<Endereco> MostraCEP(string cep)
            {
                var endereco = _context.endereco.Where(s => s.cep == cep);
                return endereco;
            }

            [HttpGet("Enderecos/EnderecosPorEstado/{uf}")]
            public IEnumerable<Endereco> MostraPorEstado(string uf)
            {
                List<Endereco> enderecos = _context.endereco.Where(s => s.uf == uf).ToList();
                return enderecos;
            }

        }
    }
