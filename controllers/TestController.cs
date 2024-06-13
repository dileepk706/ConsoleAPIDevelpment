
using Microsoft.AspNetCore.Mvc;

namespace ConsoleAPIDevelpment.Controller {

    [ApiController]
    [Route("test/[action]")]
    public class Test : ControllerBase {
        public string Get(){
            return "changede";
        }
        public string thisMethodForTestMethods(){
            return "thisMethodForTestMethods";
        }
    }
}