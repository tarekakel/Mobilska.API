using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mobilska.API.DataBase;
using Mobilska.API.Models;
using Microsoft.Extensions.Configuration;

namespace Mobilska.API.Controllers
{
  //  [Route("api/[controller]")]
  //  [ApiController]
  //  public class ClientsController : ControllerBase
  //  {
		//private IConfiguration _config;

		//public ClientsController(IConfiguration config)
  //      {
  //          _config = config;
  //      }

  //      [HttpGet]
  //      //public IActionResult ClientLogin(string userName, string pass)
  //      //{
  //      //    ClientsModel login = new ClientsModel();
  //      //    login.UserName = userName;
  //      //    login.Pass = pass;
  //      //    IActionResult response = Unauthorized();

  //      //    var user = AuthenticateUser(login);

  //      //    if (user !=null)
  //      //    {
  //      //        var tokenStr = GenerateJSONWebToken(user);
  //      //        response = Ok(new { token = tokenStr });
  //      //    }
  //      //}


  //  }
}