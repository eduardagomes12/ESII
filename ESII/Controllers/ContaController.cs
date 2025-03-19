using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ESII.ViewModels;
using ESII.Models;  // ✅ Importar a model Utilizador
using System.Threading.Tasks;

namespace ESII.Controllers
{
    public class ContaController : Controller
    {
        private readonly UserManager<Utilizador> _userManager;  // ✅ Alterado para Utilizador
        private readonly SignInManager<Utilizador> _signInManager;  // ✅ Alterado para Utilizador

        public ContaController(UserManager<Utilizador> userManager, SignInManager<Utilizador> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Login inválido!");
            return View(model);
        }

        [HttpGet]
        public IActionResult Registar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registar(RegistarViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = new Utilizador { UserName = model.Email, Email = model.Email }; // ✅ Alterado para Utilizador
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
                ModelState.AddModelError("", error.Description);

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Conta");
        }
    }
}
