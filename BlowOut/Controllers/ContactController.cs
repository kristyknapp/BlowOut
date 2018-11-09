using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using BlowOut.Models;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {


        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Name = "";
            ViewBag.Email = "";
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;

            using (MailMessage mail = new MailMessage())
            {
                //mail.From = new MailAddress(emailFromAddress);
                //mail.To.Add(emailToAddress);
                //mail.Subject = subject;
                //mail.Body = body;
                //mail.IsBodyHtml = true;
                ////mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                //using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                //{
                //    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                //    smtp.EnableSsl = enableSSL;
                //    smtp.Send(mail);
                //}
            }


            return View();
        }


        static void Email(string[] args)
        {
            SendEmail();
        }

        public static void SendEmail()
        {
            
        }
    }
}