using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CEP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

//Bruno Augusto Goetten Farias

namespace CEP.Controllers
{
    public class EnderecoController : Controller
    {

        private readonly Context _context;

        public EnderecoController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.endereco.ToList());
        }

       

        public IActionResult ConsultarCEP()
        {
            WebClient client = new WebClient();
            var cep = HttpContext.Request.Query["cep"].ToString();
            string json = client.DownloadString("http://viacep.com.br/ws/" + cep + "/json/");
            Endereco endereco = JsonConvert.DeserializeObject<Endereco>(json);

            _context.endereco.Add(endereco);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}