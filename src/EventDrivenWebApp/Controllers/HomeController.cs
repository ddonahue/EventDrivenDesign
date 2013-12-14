using System.Web.Mvc;
using EventDrivenWebApp.Events;

namespace EventDrivenWebApp.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        private readonly IEventPublisher eventPublisher;

        public HomeController(IEventPublisher eventPublisher)
        {
            this.eventPublisher = eventPublisher;
        }

        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult SubmitOrder()
        {
            eventPublisher.Publish(new OrderSubmittedEvent { OrderId = 666 });

            return RedirectToAction("Index");
        }
    }
}