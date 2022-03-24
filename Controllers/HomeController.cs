using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eInvite.Models;

namespace eInvite.Controllers
{
    public class HomeController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
            [HttpGet]
            public ViewResult RsvpForm()
            {
                return View();
            }

            [HttpPost]
            public ViewResult RsvpForm(GetResponse getResponse)
            {
                if (ModelState.IsValid)
                {
                    Repository.AddResponse(getResponse);
                    return View("Thanks", getResponse);
                }
                else
                {
                    return View();
                }
            }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

    }
}
