using Microsoft.AspNetCore.Mvc;
using WebApi2.ApiProxy;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    [ApiController]
    [Route("/users/")]
    public class Users : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUser(Guid Id)
        {
            return Ok(Id);
        }


        [HttpPost]
        public IActionResult CreateUser(GetUSerRequest request)
        {
            var newUser = new UserModel(
                Guid.NewGuid(),
                request.FirstName,
                request.LastName,
                request.Age);
           
            return Ok(newUser);
        }


        [HttpPut("{id}")]
        public IActionResult PutUser( Guid Id,GetUSerRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid Id)
        {
            return Ok(Id);
        }
    }
}
