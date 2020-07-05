using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PolCal.Controllers
{
    public class PolColController : Controller
    {
        // 
        // GET: /HelloWorld/
    //public PolColController()
        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}