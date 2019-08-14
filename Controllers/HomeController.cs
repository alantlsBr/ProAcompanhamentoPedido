using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAcompanhamentoPedido.Models;
using ProAcompanhamentoPedido.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProAcompanhamentoPedido.Controllers
{
    public class HomeController : Controller
    {
        private readonly AcompanhamentoContexto _context;

        public HomeController(AcompanhamentoContexto context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Pedido> pedidos = await _context.Pedidos.Include(p => p.Cliente).ToListAsync();

            return View(pedidos);
        }
    }
}
