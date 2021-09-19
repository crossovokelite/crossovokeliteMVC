using System;
using System.Web.Mvc;

namespace crossovokeliteMVC.Controllers
{
    public class ProfileController : EagletControllerBase
    {
        //
        // GET: /Profile/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            throw new NotImplementedException();
        }

    }
}
