using ProblemFive.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProblemFive.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string password = "altug";
          

            
            int key = Convert.ToInt32(-2);
         

            string cipherText = CaesarCipher.Encipher(password, key);

            string t = CaesarCipher.Decipher(cipherText, key);


            string burak = "";

            return View();
        }

        [HttpPost]
        public ActionResult EncryptionFile(HttpPostedFileBase file, int index, string password)
        {
            return View();
        }

        [HttpPost]
        public ActionResult DecryptionFile(HttpPostedFileBase file, int index, string password)
        {
            return View();
        }
    }
}
