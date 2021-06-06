using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DamThanhNgan_17.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }    
            else
            {
                return RedirectToLocal("Index", "Home");
            }    
        }
    }
}