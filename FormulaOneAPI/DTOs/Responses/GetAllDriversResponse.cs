namespace FormulaOneAPI.DTOs.Responses
{
    public class GetAllDriversResponse
    {
        public List<DriverDto> Drivers { get; set; } = new List<DriverDto>();
    }
}
