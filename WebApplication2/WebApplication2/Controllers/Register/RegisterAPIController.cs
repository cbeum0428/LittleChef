using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class RegisterAPIController : Controller
    {
		[HttpPut]
		[Route("RegisterUser")]
		public void RegisterUser(string firstName, string lastName, string username, string password)
		{

		}
	}
}