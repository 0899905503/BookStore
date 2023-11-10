using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
          
     
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Index";
            ViewData["Sachnauan"]=Database.dbContext.Sachs.Where(x=>x.Maloaisach==2).ToList();
            ViewData["Sachtreem"]=Database.dbContext.Sachs.Where(x=>x.Maloaisach==1).ToList();
            ViewData["Comicbook"]=Database.dbContext.Sachs.Where(x=>x.Maloaisach==3).ToList();
            return View();
            
        }

        public ActionResult ChitietBookTE(int id)
        {
            ViewBag.Title = "SachFE";


            if (id == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            Sach sach=Database.dbContext.Sachs.Find(id);
            ViewData["SachFE"] = Database.dbContext.Sachs.SingleOrDefault(x=>x.Id==id);
            ViewData["SachFEcungloai"]=Database.dbContext.Sachs.Where(x=>x.Maloaisach==sach.Maloaisach).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Search()
        {
            ViewBag.Title = "SearchFE";

            String name = HttpContext.Request.Form["Search"].ToString();
                List<Sach> sach = Database.dbContext.Sachs.Where(x => x.Ten == name).ToList();
            ViewData["Search"] =name ;
                return View();
            
            
        }
        
        public  IActionResult Header()
        {
            /*
            string Input = Request.Form["input"];
            SanPham Book;           
            Book = _dbContext.SanPhams.SingleOrDefault(x => x.Idlsp.ToString() == Input);  
            */
           
            return PartialView();

        }
      
        public PartialViewResult ComicBook()
        {
            return PartialView();
        }
        public PartialViewResult Childrens_Book()
        {
            return PartialView();
        }
        public PartialViewResult FeaturedProduct()
        {
            return PartialView();
        }
        public PartialViewResult Maketing()
        {
            return PartialView();
        }

     
    }
}
