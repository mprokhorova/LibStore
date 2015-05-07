using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Index/

        public String Index()
        {
            return "hey from Store.Index";
        }

        //GET: /Browse?genre=classic
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Hey from Store.Browse, genre =" + genre);
            return message;
        }

        //GET: /Details/
        public string Details(int ID)
        {
            string message = "Hey from Store.Details, id = " + ID;

            return message;
        }
    }
}
