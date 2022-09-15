using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {
        BanXeEntities2 ctx = new BanXeEntities2();

        // GET: Adminn
        public ActionResult Index()
        {            
            return View();
        }
        
        public ActionResult Products()
        {
            //1. db --> toys
            //select * from Toys
            List<ThongTinXe> xes = ctx.ThongTinXes.ToList();

            //2.pasing data to view
            return View(xes);
        }

        public ActionResult ProductDetails(int id)
        {
            //select * from Toys where 
            ThongTinXe xe = ctx.ThongTinXes.Where(t => t.id == id).SingleOrDefault();
            ViewBag.productId = id;

            //passing data /model to view
            return View(xe);
        }

        public ActionResult DeleteProduct(int id)
        {
            ThongTinXe xe = ctx.ThongTinXes.Where(t => t.id == id).SingleOrDefault();

            //xoa
            ctx.ThongTinXes.Remove(xe);
            ctx.SaveChanges();

            //redirect view
            return RedirectToAction("Products");
        }

        [HttpPost]
        public ActionResult SaveProduct(ThongTinXe xe)
        {
            //save to db
            ctx.ThongTinXes.Add(xe);
            ctx.SaveChanges();

            return RedirectToAction("Products");
        }

        public ActionResult Customers()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            ThongTinXe xe = new ThongTinXe();

            // list category
            List<DanhMuc> danhMucs = ctx.DanhMucs.Where (c=>c.id > 1 && c.id<7).ToList();
            ViewBag.danhMucs = danhMucs;           

            return View(xe);
        }

        public ActionResult EditProduct(int id)
        {
            ThongTinXe xe = ctx.ThongTinXes.Where(t=>t.id == id).SingleOrDefault();

            // list category
            List<DanhMuc> danhMucs = ctx.DanhMucs.Where(c => c.id > 1 && c.id < 7).ToList();
            ViewBag.danhMucs = danhMucs;

            return View(xe);
        }

        [HttpPost]
        public ActionResult UpdateProduct(ThongTinXe thongTinXe)
        {
            //search old entity
            ThongTinXe thongTin = ctx.ThongTinXes.Where(t => t.id == thongTinXe.id).SingleOrDefault();

            //update
            thongTin.ten = thongTinXe.ten;
            thongTin.thong_so_ky_thuat = thongTinXe.thong_so_ky_thuat;
            thongTin.mau_sac = thongTinXe.mau_sac;
            thongTin.gia = thongTinXe.gia;
            thongTin.hinh = thongTinXe.hinh;            

            //save to db          
            ctx.SaveChanges();

            return RedirectToAction("Products");
        }

        [HttpPost]
        public ActionResult SaveBrand(DanhMuc danhMuc)
        {
            //save to db
            ctx.DanhMucs.Add(danhMuc);
            ctx.SaveChanges();

            return RedirectToAction("Brands");
        }

        public ActionResult AddBrand()
        {
            DanhMuc dm = new DanhMuc();           

            return View(dm);
        }                        

        public ActionResult Brands()
        {
            //1. db --> toys
            //select * from Toys
            List<DanhMuc> dm = ctx.DanhMucs.ToList();

            //2.pasing data to view
            return View(dm);
        }

        public ActionResult EditBrand(int id)
        {
            DanhMuc xe = ctx.DanhMucs.Where(t => t.id == id).SingleOrDefault();
            // list category

            List<DanhMuc> danhMucs = ctx.DanhMucs.Where(c => c.id > 1 && c.id < 7).ToList();
            ViewBag.danhMucs = danhMucs;

            return View(xe);
        }

        [HttpPost]
        public ActionResult UpdateBrand(DanhMuc danhMuc)
        {
            //search old entity
            DanhMuc danhMuc1 = ctx.DanhMucs.Where(t => t.id == danhMuc.id).SingleOrDefault();

            //update
            danhMuc1.name = danhMuc.name;       

            //save to db          
            ctx.SaveChanges();

            return RedirectToAction("Brands");
        }

        public ActionResult DeleteBrand(int id)
        {
            DanhMuc dm = ctx.DanhMucs.Where(t => t.id == id).SingleOrDefault();

            //xoa
            ctx.DanhMucs.Remove(dm);
            ctx.SaveChanges();

            //redirect view
            return RedirectToAction("Brands");
        }
    }
}

