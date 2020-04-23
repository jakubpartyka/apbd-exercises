namespace Kolokwium1.Controllers

{

    [Route("api/prescriptions")]

    [ApiController]

    public class PrescriptionsController : ControllerBase

    {

        [HttpGet("{id}")]

        public IActionResult GetPerscription(int id)

        {
        }
        
    }
    
}
