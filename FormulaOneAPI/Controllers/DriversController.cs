using FormulaOneAPI.DTOs.Requests;
using FormulaOneAPI.DTOs.Responses;
using FormulaOneAPI.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneAPI.Controllers
{
    [ApiController]
    [Route("api/drivers")]
    public class DriversController : ControllerBase
    {
        private readonly GetAllDriversHandler _getAllDriversHandler;

        public DriversController(GetAllDriversHandler getAllDriversHandler)
        {
            _getAllDriversHandler = getAllDriversHandler;
        }

        [HttpGet]
        public async Task<ActionResult<GetAllDriversResponse>> GetAllDrivers(GetAllDriversRequest request)
        {
            var response = await _getAllDriversHandler.Handle(request);
            return Ok(response);
        }
    }
}
