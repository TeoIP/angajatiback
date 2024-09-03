using Microsoft.AspNetCore.Mvc;

namespace NewMask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CodeVerificationController : ControllerBase
    {
        public class User
        {
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string birthday { get; set; }
            public string placeOfWork { get; set; }
            public string function { get; set; }
            public string vacationDay { get; set; }
        }

        [HttpGet]
        [Route("/api/mobile/getuserinfo", Name = "GetUserInfo")]
        public object GetUserInfo(string id)
        {
            return new { error = "" };
        }

        [HttpGet]
        [Route("/api/mobile/login", Name = "Login")]
        public object Login(string id, string code)
        {
            var user=new User
            {
                Id="123123",
                FirstName="Oleg",
                LastName="Petrov",
                Address="str Puscin 23",
                Email= "example@gmail.com",
                Phone="079888208",
                birthday="23/12/2005",
                placeOfWork="Linella 20",
                function="Casier",
                vacationDay= "12",

            };
            return new { error = "", data= user };
        }
    }
}
