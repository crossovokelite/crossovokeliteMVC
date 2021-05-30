using crossovokeliteMVC.ViewModel;
using System;
using System.Linq;
using System.Web.Mvc;

namespace crossovokeliteMVC.Controllers
{
    public class HomeController : RcrdControllerBase
    {
        public HomeController() : base() { }

        public ActionResult Index()
        {
            if (!Security.IsAuthenticated)
            {
                return View("Landing", new LoginSignupViewModel());
            }

            var timeline = Rcrds.GetTimelineFor(Security.UserId).ToArray();

            return View("Timeline", timeline);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Follow(string username)
        {
            throw new NotImplementedException(username + " followed");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Unfollow(string username)
        {
            throw new NotImplementedException(username + " unfollowed");
        }

        public ActionResult Profiles()
        {
            throw new NotImplementedException();
        }

        public ActionResult Followers()
        {
            throw new NotImplementedException();
        }

        public ActionResult Following()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [ChildActionOnly]
        public ActionResult Create()
        {
            return PartialView("_CreateRcrdPartial", new CreateRcrdViewModel());
        }

        [HttpPost]
        [ChildActionOnly]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateRcrdViewModel model)
        {
            if (ModelState.IsValid)
            {
                Rcrds.Create(Security.UserId, model.Status);

                Response.Redirect("/");
            }

            return PartialView("_CreateRcrdPartial", model);
        }

    }
}
