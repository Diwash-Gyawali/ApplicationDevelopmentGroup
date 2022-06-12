using groupCW.Data;
using groupCW.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace groupCW.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<AspUserViewModel> l = _context.Users.Select(x => new AspUserViewModel
            {
                UserName = x.UserName,
                Email = x.Email,
                PasswordHash = x.PasswordHash,
                Id = x.Id,
            }).ToList();

            return View(l);
        }
    }
}
