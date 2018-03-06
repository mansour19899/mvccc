using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcc.Controllers
{
    public class myController : Controller
    {
        // GET: my
        public ActionResult Index()
        {
            user man = new user() {name = "ali",family = "mohammadi"};
            Session["name"] = man;
            return View();
        }
        public ActionResult me()
        {
            var q = Session["name"] as user;

            return Content(q.name+q.family);
        }
    }

    class user
    {
        public string name { get; set; }
        public string family { get; set; }
    }
}