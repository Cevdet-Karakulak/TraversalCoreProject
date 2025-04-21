using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MailRequest mailRequest)
        {
            if (!ModelState.IsValid)
            {
                return View(mailRequest);
            }

            try
            {
                MimeMessage mimeMessage = new MimeMessage();

                MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "karakulakcevdet@gmail.com");
                mimeMessage.From.Add(mailboxAddressFrom);

                if (string.IsNullOrWhiteSpace(mailRequest.ReceiverMail))
                {
                    ModelState.AddModelError("ReceiverMail", "Alıcı e-posta adresi boş olamaz.");
                    return View(mailRequest);
                }

                MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
                mimeMessage.To.Add(mailboxAddressTo);

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = mailRequest.Body;
                mimeMessage.Body = bodyBuilder.ToMessageBody();

                mimeMessage.Subject = mailRequest.Subject;

                using (SmtpClient client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("karakulakcevdet@gmail.com", "bqchehivwoghfkhx");
                    client.Send(mimeMessage);
                    client.Disconnect(true);
                }

                ViewBag.Message = "Mail başarıyla gönderildi.";
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Mail gönderimi sırasında bir hata oluştu: {ex.Message}");
            }

            return View();
        }
    }
}
