using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcgmail.Models;
using System.Net;
using System.Net.Mail;


namespace mvcgmail.Controllers
{
    public class EmailSetupController : Controller
    {
        // GET: EmailSetup
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(mvcgmail.Models.gmail model)
        {
            MailMessage mm = new MailMessage("varad28potdar@gmail.com", model.To);
            mm.Subject = model.Subject;
            mm.Body = model.Body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;


            NetworkCredential nc = new NetworkCredential("varad28potdar@gmail.com", "VaradP@2001");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            ViewBag.Message = "Mail Has Been Sent Sccessfully!";
            return View();
        }
    }
}