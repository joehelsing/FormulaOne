using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using FormulaOneAPI.Controllers;
using FormulaOneAPI.Handlers;
using FormulaOneAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using FormulaOneAPI.DTOs.Requests;
using FormulaOneAPI.DTOs.Responses;
using FormulaOneAPI.DTOs;
using FormulaOneAPI.Handlers.Interfaces;

namespace FormulaOneAPI.Controllers.Tests
{
    public class DriversControllerTests
    {
        [Fact]
        public async Task GetAllDrivers_ReturnsOkResult()
        {
            // Arrange
            var mockHandler = new Mock<IGetAllDriversHandler>();
            mockHandler.Setup(handler => handler.Handle(It.IsAny<GetAllDriversRequest>()))
                       .ReturnsAsync(new GetAllDriversResponse { Drivers = new List<DriverDto>() });

            var controller = new DriversController(mockHandler.Object);

            // Act
            var result = await controller.GetAllDrivers(new GetAllDriversRequest());

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            Assert.NotNull(okResult.Value);
        }
    }
}