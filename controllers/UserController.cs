
using Microsoft.AspNetCore.Mvc;

namespace UserController{
    [ApiController]
    [Route("/dileep")]
    public class user:ControllerBase{

        public string userName(){
            return "gi";
        }
    }
}