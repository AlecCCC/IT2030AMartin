using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class ProductController : Controller
    {
        public string Index()
        {
            return "Product/Index Is Displayed";
        }

        public string Browse()
        {
            return "Browse displayed";
        }


        public string Details(int ID)
        {
            return "Details displayed for Id=" + ID;

        }


        public string Location(int zip)
        {
            string message = HttpUtility.HtmlEncode("Location displayed for zip=" + zip);
            return message;
        }

    }

}