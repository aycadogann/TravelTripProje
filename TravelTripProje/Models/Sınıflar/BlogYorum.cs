using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> GetBlogs { get; set; }
        public IEnumerable<Blog> AllBlogs { get; set; }
        public IEnumerable<Yorumlar> GetYorumlars { get; set; }
    }
}