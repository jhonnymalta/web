using Microsoft.AspNetCore.Mvc;
using SWE.Identidade.Web.Models;

namespace SWE.Identidade.Web.Controllers
{
    public class IdentidadeController : Controller
    {
        [HttpGet("nova-conta")]
        public IActionResult Registro(UsuarioRegistro usuarioRegistro)
        {
            return View();
        }
        [HttpPost("nova-conta")]
        public IActionResult Registro()
        {
            return View();
        }
        [HttpGet("login")]
        public IActionResult Login(UsuarioLogin usuarioLogin)
        {
            return View();
        }
        [HttpPost("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet("sair")]
        public IActionResult logout()
        {
            return View();
        }
    }
}
