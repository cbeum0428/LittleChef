using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication2.DAL.Login;
using WebApplication2.Models;

namespace WebApplication2.Controllers.Login
{
    public class LoginAPIController : Controller
    {
		private static LoginDAL loginDAL = new LoginDAL();

		[Route("VerifyCredentials")]
        public JsonNetResult VerifyCredentials (string username, string password)
		{
			return new JsonNetResult(loginDAL.VerifyCredentials(username, password));
		}
    }
}