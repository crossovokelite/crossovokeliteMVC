using System;
using System.Web.Mvc;

namespace crossovokeliteMVC.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index(string username)
        {
            throw new NotImplementedException("list for " + username);
        }
    }
}
