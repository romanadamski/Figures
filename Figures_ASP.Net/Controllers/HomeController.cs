using Figures_ASP.Net.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Figures_ASP.Net.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        BaseFigures GetFigure(string figureName)
        {
            switch (figureName)
            {
                case "square":
                    return new Square();
                case "rectangle":
                    return new Rectangle();
                case "triangle":
                    return new Triangle();
                case "circle":
                    return new Circle();
                case "parallelogram":
                    return new Parallelogram();
                case "diamond":
                    return new Diamond();
                case "trapeze":
                    return new Trapeze();
                default:
                    return null;
            }
        }
        [HttpGet]
        public JsonResult GetDescription(string figureName)
        {
            var figure = GetFigure(figureName);
            if (figure == null)
                return Json(new { text = "" }, JsonRequestBehavior.AllowGet);
            return Json(new { text = figure.FormatDescription }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetResult(string figureName, string parameters)
        {
            var figure = GetFigure(figureName);
            if (figure == null)
                return Json(new { text = "0" }, JsonRequestBehavior.AllowGet);
            figure.Parameters = parameters;
            return Json(new { result = figure.Result }, JsonRequestBehavior.AllowGet);
        }
    }
}