using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        BlogYorum blogYorum = new BlogYorum();

        public ActionResult Index()
        {
            //var degerler = context.Blogs.ToList();
            blogYorum.GetBlogs = context.Blogs.ToList();
            blogYorum.AllBlogs = context.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return View(blogYorum);
        }

        public ActionResult BlogDetay(int id)
        {
            //var blogBul = context.Blogs.Where(x => x.ID == id);
            blogYorum.GetBlogs = context.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.GetYorumlars = context.Yorumlars.Where(x => x.BlogId == id).ToList();
            return View(blogYorum);
        }

    }
}