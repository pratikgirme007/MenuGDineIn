using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserLogin.Models;
using UserLogin.Models.DAL;

namespace UserLogin.Controllers
{
    public class UserLoginsController : Controller
    {
        private MenuGDbContext db = new MenuGDbContext();

       // GET: UserLogin
        public ActionResult Index()
        {
           /* var list = db.UserLoginDtoes.ToList()*/

            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {

            return View ();
        }
        [HttpPost]
        public ActionResult Login(UserLoginDto userLogin)
        {
            var UserData = db.UserLoginDtoes.Where(x => x.userid == userLogin.userid).FirstOrDefault();
            if (UserData != null)
            {
                UserData.userid = userLogin.userid;
                return RedirectToAction("Index", "UserLogins");
            }
            return View();
        }








        // GET: UserLogin/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: UserLogin/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: UserLogin/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserLogin/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: UserLogin/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserLogin/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: UserLogin/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
