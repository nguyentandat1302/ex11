using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex11.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(string MaSV, string HoTenSV, double DiemSo)
        {
            try
            {


                var path = Server.MapPath("~/Data.txt");
                string[] lines = { MaSV, HoTenSV, DiemSo.ToString() };
                System.IO.File.WriteAllLines(path, lines);
                ViewBag.KetQua = "Ghi Thanh Cong";
               
            }
            catch (Exception ex)
            {
                ViewBag.KetQua = "Ghi that Bai";
            }
            return View("Index");
        }
        public ActionResult Open()
        {
            try
            {
                var path = Server.MapPath("~/Data.txt");
                string[] lines = System.IO.File.ReadAllLines(path);
                ViewBag.MaSV = lines[0];
                ViewBag.HoTenSV = lines[1];
                ViewBag.DiemSo = lines[2];
                ViewBag.KetQua = "Doc Thanh Cong";



            }
            catch (Exception ex)
            {

                ViewBag.KetQua = "Doc that Bai";
            }
            return View("Index");
        }
    }
}