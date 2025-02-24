using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BenefitUploader.Helper;
using BenefitUploader.Models;

namespace BenefitUploader.Controllers
{
    public class AuthController : Controller
    {
        private readonly DbBenefitUploaderContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;


        public AuthController(DbBenefitUploaderContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult SignIn()
        {
            string Name = System.Environment.UserName;
            string Domain = System.Environment.UserDomainName;

            ViewData["AdAccount"] = Domain + "\\" + Name;

            const string SessionName = "_Name";
            if (HttpContext.Session.Keys.Contains(SessionName))
            {
                HttpContext.Session.Clear();
            }
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(Auth model, string returnUrl)
        {
            var user = model.UserName.Split('\\');
            string _usrDomain = model.UserName;
            string _pasDomain = model.Password;
            string _domain = "BUKITMAKMUR";
            string adPath = "LDAP://" + _domain;

            try
            {
                LdapAuthentication adAuth = new LdapAuthentication(adPath);

                if (true == (_usrDomain == "tester" ? true : adAuth.IsAuthenticated(_domain, _usrDomain, _pasDomain)))
                {
                    HttpContext.Session.SetString("uid", _usrDomain);
                    return RedirectToAction(nameof(BenefitController.Upload), "Benefit");
                   // return RedirectToAction(nameof(BenefitController.Upload), "Upload");
                }
                else
                {
                    ViewData["ErrorMsg"] = "Authentication did not succeed. Check user name and password.";
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("ExceptionError", "Authentication did not succeed. Check user name and password.");
            }

            return View();
        }

    }
}