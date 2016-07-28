using E_Book.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Book.ViewModel
{
    public class E_BookViewModel
    {
        public virtual List<Book> listBook { set; get; }
        public virtual List<SelectListItem> LstCategories { set; get; }
        public virtual string ParentURL { get; set; }
    }
}