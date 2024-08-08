using customer_datagrid_backend.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableManagementAPI.Controllers;
using TableManagementAPI.Models;
using TableManagementAPI.Services;

namespace customer_datagrid_test
{
    [TestFixture]
    public class RecordsControllerTests
    {
        private Mock<IRecordService> _mockService;
        private RecordsController _controller;

        [SetUp]
        public void Setup()
        {
            _mockService = new Mock<IRecordService>();
            _controller = new RecordsController(_mockService.Object);
        }

        //[Test]
        //public async Task GetAllRecords_ReturnsOkResult_WithListOfRecords()
        //{
        //    // Arrange
        //    var records = new List<Record>
        //    {
        //        new Record { Id = 1,  DummyCorpName = "Corp A", DummyDistrictName = "District A", DummyWorkDone = 100, DummyManDays = 5, DummyManpowerCost = 5000, DummyEquipmentCost = 2000, DummyTotalCost = 9000 },
        //        new Record { Id = 2, DummyCorpName = "Corp B", DummyDistrictName = "District B", DummyWorkDone = 150, DummyManDays = 8, DummyManpowerCost = 8000, DummyEquipmentCost = 3000, DummyTotalCost = 11000 }
        //    };

        //    _mockService.Setup(service => service.GetAllRecords()).ReturnsAsync(records);

        //    // Act
        //    var result = _controller.GetAllRecords();

        //    // Assert
        //    Assert.IsInstanceOf<OkObjectResult>(result.Result);
        //    var okResult = result.Result as OkObjectResult;
        //    Assert.IsNotNull(okResult);

        //    dynamic responseObject = okResult.Value;
        //    Assert.IsNotNull(responseObject);
        //    Assert.AreEqual("success", responseObject.status);
        //    Assert.AreEqual("Records retrieved successfully.", responseObject.message);
        //    Assert.IsInstanceOf<IEnumerable<Record>>(responseObject.data);
        //    var returnRecords = responseObject.data as List<Record>;
        //    Assert.AreEqual(2, returnRecords.Count);
        //}
    }


}
