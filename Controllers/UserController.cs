using fitness.Data;
using Microsoft.AspNetCore.Mvc;

namespace fitness.Controllers
{
    public class UserController : Controller
    {

        //request applicataion to send the object of ApplicationDbContext to work with database
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db) //can access whatever is register inside the container i.e. the two line of code in program.cs as parameter in constructor
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objUserList = _db.Users.ToList();
            return View();
        }
    }
}
