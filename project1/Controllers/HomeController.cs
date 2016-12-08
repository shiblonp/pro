using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Controllers
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
        public ActionResult MissPage()
        {
            return View();
        }
        public ActionResult Mission(string mission)
        {
            if(mission=="Tonga")
            {
                ViewBag.Name = "Tonga, Nuku'alofa Mission";
                ViewBag.Pic = Url.Content("~/Images/peopleTonga.jpg");
                ViewBag.Flag = Url.Content("~/Images/flagTonga.png");
                ViewBag.Temple = Url.Content("~/Images/templeTonga.jpg");
                ViewBag.President = "Sione Tuione";
                ViewBag.Language = "Tongan";
                ViewBag.Climate = "Tropical";
                ViewBag.Address = "<address>Tonga Nuku’alofa Mission</br>P.O. Box 58</br>Nuku’alofa, Tongatapu, Tonga</br>South Pacific</address>";
                ViewBag.Religion = "Free Weslyan";
                ViewBag.Answer1 = "Typical foods include roots such as tapioca as well as Lupulu, and pork";
                ViewBag.Answer2 = "Tongans are generally receptive to the missionaries because many Tongans have family members who are members of the church";
                ViewBag.Answer3 = "Tongans typically commute by walking because the distance on each respective island is relatively small";
            }
            else if(mission=="Florida")
            {
                ViewBag.Name = "Florida, Orlando Mission";
                ViewBag.Pic = Url.Content("~/Images/peopleFl.jpg");
                ViewBag.Flag = Url.Content("~/Images/flagFl.jpg");
                ViewBag.Temple = Url.Content("~/Images/templeFl.jpg");
                ViewBag.President = "David K. Clark";
                ViewBag.Language = "English";
                ViewBag.Climate = "Tropical";
                ViewBag.Address = "<address>Florida Orlando Mission</br>10502 Satellite Blvd Ste E</br>Orlando, FL 32837-8426</address>";
                ViewBag.Religion = "Catholic";
                ViewBag.Answer1 = "Typical foods in Florida include foods that are typical to other states, such as BBQ";
                ViewBag.Answer2 = "Reception to missionaries is different througout Florida because of the large mix of cultures";
                ViewBag.Answer3 = "The commute in Florida is typically by car, public transportation isn't very developed there";
            }
            else if(mission=="Salvador")
            {
                ViewBag.Name = "El Salvador, San Salvador East Mission";
                ViewBag.Pic = Url.Content("~/Images/peopleSal.jpg");
                ViewBag.Flag = Url.Content("~/Images/flagSal.jpg");
                ViewBag.Temple = Url.Content("~/Images/templeSal.jpg");
                ViewBag.President = "David L. Glazier";
                ViewBag.Language = "Spanish";
                ViewBag.Climate = "Tropical";
                ViewBag.Address = "<address>Mision El Salvador, San Salvador Este</br>Centro Commercial 105, Local 204</br>Paseo General Escalon y 105 Ave. Sur</br>San Salvador, El Salvador, C.A.</address>";
                ViewBag.Religion = "Roman Catholic";
                ViewBag.Answer1 = "El Salvador is famous for their Pupusas. They also eat rice and beans";
                ViewBag.Answer2 = "People are very receptive to missionaries in El Salvador because of their humble living circumstances";
                ViewBag.Answer3 = "Public transportation such as buses is the main source for comuters in El Salvador";
            }

            return View();
        }
    }
}