using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using E_Book.Models.Pages;
using System.IO;

namespace E_Book.Controllers
{
    public class BookController : PageController<Book>
    {
        public ActionResult Index(Book currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
        //public FileStreamResult GetPDF()
        //{
        //    Book bk = new Book();
        //    string filepath = @"~\Book1.pdf";
            

        //    FileStream fs = new FileStream(Server.MapPath(filepath), FileMode.Open, FileAccess.Read);
        //    return File(fs, "application/pdf");
        //}
    }
}