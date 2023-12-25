using EgyHeart.Data;
using EgyHeart.Models.M_Medical;
using Microsoft.AspNetCore.Mvc;

namespace EgyHeart.Controllers
{
    public class PatController : Controller
    {
        private readonly AppDbContext _context;

        public PatController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Pat pat)
        {
            if (ModelState.IsValid)
            {
                pat.PatPassword = "123456";
                _context.Add(pat);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Pat pat)
        {
            Pat myPat = _context.Pats.FirstOrDefault(p => p.PatId == pat.PatId && p.PatPassword == pat.PatPassword);
            if (myPat != null) 
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Register", "Pat");
        }
    }

}
