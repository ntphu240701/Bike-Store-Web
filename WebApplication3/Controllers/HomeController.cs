using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        BanXeEntities2 ctx = new BanXeEntities2();

        public ActionResult Index(int? id)
        {
            List<DanhMuc> hang = ctx.DanhMucs.ToList();
            ViewBag.hang = hang;

            if (id == null)
            {
                List<ThongTinXe> xe = ctx.ThongTinXes.ToList();
                ViewBag.xe = xe;
            }
            else
            {
                List<ThongTinXe> xe = ctx.ThongTinXes.Where(x=>x.danhmucid == id).ToList();
                ViewBag.xe = xe;
            }
            //lay du lieu tu database
           
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
    }
}