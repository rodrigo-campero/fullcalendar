using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Daycoval.DayBot.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FullCalendar()
        {
            return View();
        }

        public JsonResult Events(DateTime start, DateTime end)
        {
            var list = new List<object> {
                new {
                title= "event1",
                start= "2019-05-01"
            },
            new {
                title= "event2",
                start= "2019-05-05",
                end= "2019-05-07"
            },
            new{
                title= "event3",
                start= "2019-05-09T12:30:00",
                allDay= false, // will make the time show
                backgroundColor= "red",
                borderColor= "black",
                textColor= "white"
            },
            new{
                title= "event4",
                start= "2019-05-09T13:00:00",
                allDay= false, // will make the time show
                backgroundColor= "green",
                borderColor= "black",
                textColor= "white"
            },
            new{
                title= "event3",
                start= "2019-05-09T13:30:00",
                allDay= false, // will make the time show
                backgroundColor= "red",
                borderColor= "black",
                textColor= "white"
            },
            new{
                title= "event4",
                start= "2019-05-09T14:00:00",
                allDay= false, // will make the time show
                backgroundColor= "green",
                borderColor= "black",
                textColor= "white"
            },
            new{
                title= "event3",
                start= "2019-05-09T14:30:00",
                allDay= false, // will make the time show
                backgroundColor= "red",
                borderColor= "black",
                textColor= "white"
            },
            new{
                title= "event4",
                start= "2019-05-09T15:00:00",
                allDay= false, // will make the time show
                backgroundColor= "green",
                borderColor= "black",
                textColor= "white"
            },
            new{
                title= "event3",
                start= "2019-05-09T15:30:00",
                allDay= false, // will make the time show
                backgroundColor= "red",
                borderColor= "black",
                textColor= "white"
            },
            new{
                title= "event4",
                start= "2019-05-09T16:00:00",
                allDay= false, // will make the time show
                backgroundColor= "green",
                borderColor= "black",
                textColor= "white"
            },
            new{
                title= "event3",
                start= "2019-05-09T16:30:00",
                allDay= false, // will make the time show
                backgroundColor= "red",
                borderColor= "black",
                textColor= "white"
            },
            new{
                title= "event4",
                start= "2019-05-09T17:00:00",
                allDay= false, // will make the time show
                backgroundColor= "green",
                borderColor= "black",
                textColor= "white"
            },
            new{
                title= "event4",
                start= DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                allDay= false, // will make the time show
                backgroundColor= "green",
                borderColor= "black",
                textColor= "white"
            }
            };
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}