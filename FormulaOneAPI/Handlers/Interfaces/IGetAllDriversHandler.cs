using FormulaOneAPI.DTOs.Requests;
using FormulaOneAPI.DTOs.Responses;

namespace FormulaOneAPI.Handlers.Interfaces
{
    public interface IGetAllDriversHandler
    {
        Task<GetAllDriversResponse> Handle(GetAllDriversRequest request);
    }
}
