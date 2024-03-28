using FormulaOneAPI.Data;
using FormulaOneAPI.DTOs.Requests;
using FormulaOneAPI.DTOs.Responses;
using FormulaOneAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using FormulaOneAPI.Handlers.Interfaces;

namespace FormulaOneAPI.Handlers
{
    public class GetAllDriversHandler : IGetAllDriversHandler
    {
        private readonly FormulaOneDbContext _dbContext;

        public GetAllDriversHandler(FormulaOneDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetAllDriversResponse> Handle(GetAllDriversRequest request)
        {
            // Fetch all drivers from the database. AsQueryable in case we want to add filtering later.
            var driversQuery = _dbContext.Drivers.AsQueryable();

            // Map drivers to DTOs
            var driverDtos = driversQuery.Select(d => new DriverDto
            {
                Id = d.Id,
                Number = d.Number,
                Code = d.Code,
                Forename = d.Forename,
                Surname = d.Surname,
                DOB = d.DOB,
                Nationality = d.Nationality,
                URL = d.URL
            }).ToList();

            return new GetAllDriversResponse
            {
                Drivers = driverDtos
            };
        }
    }
}
