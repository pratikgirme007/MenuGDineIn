using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserLogin.Models.DAL;

namespace UserLogin.Controllers
{
    public class UserRegistrationController : Controller
    {
        private MenuGDbContext db = new MenuGDbContext();
        // GET: UserRegistration
        public ActionResult Index()
        {
            var list = db.UserLoginDtoes.ToList();
            return View(list);

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View ();
        }
        [HttpPost]
       
        public ActionResult Create(UserDetail userDetail)
        {
            userDetail.CreatedDate = DateTime.Now;
            userDetail.ModifiedDate = DateTime.Now;
            db.UserDetails.Add(userDetail);
            db.SaveChanges();
            return View();
        }
    }
}