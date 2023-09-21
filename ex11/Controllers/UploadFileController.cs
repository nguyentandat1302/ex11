using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex11.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFile
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UpLoad()
        {
            var image = Request.Files["image"];
            var document = Request.Files["document"];
            var path = Server.MapPath("~/UpLoad/");
            if (image != null && image.ContentLength>0) {
                image.SaveAs(path + image.FileName);
                ViewBag.FileNameImage = image.FileName;
            }
            if (document != null && document.ContentLength > 0)
            {
                document.SaveAs(path + document.FileName);
                ViewBag.FileName = document.FileName;
                ViewBag.FileSize = document.ContentLength;
                ViewBag.FileStyle = document.ContentType;



            }

            return View();
            
        }
    }
}