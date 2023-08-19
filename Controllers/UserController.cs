using fitness.Data;
using fitness.Models;
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
            IEnumerable<User> objUserList = _db.Users;  //convert from var to IEnumerbale for strongly typed
            return View(objUserList);
        }

        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken] // prevent the cross site frogery attacks
        public IActionResult Create(User obj)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
 