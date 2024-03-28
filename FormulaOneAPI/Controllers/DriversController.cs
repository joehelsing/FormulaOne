using FormulaOneAPI.DTOs.Requests;
using FormulaOneAPI.DTOs.Responses;
using FormulaOneAPI.Handlers;
using FormulaOneAPI.Handlers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneAPI.Controllers
{
    [ApiController]
    [Route("api/drivers")]
    public class DriversController : ControllerBase
    {
        private readonly IGetAllDriversHandler _getAllDriversHandler;

        public DriversController(IGetAllDriversHandler getAllDriversHandler)
        {
            _getAllDriversHandler = getAllDriversHandler;
        }

        [HttpPost]
        public async Task<ActionResult<GetAllDriversResponse>> GetAllDrivers(GetAllDriversRequest request)
        {
            var response = await _getAllDriversHandler.Handle(request);
            return Ok(response);
        }
    }
}
