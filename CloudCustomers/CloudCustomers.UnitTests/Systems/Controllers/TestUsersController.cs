using CloudCustomers.API.Controllers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class TestUsersController
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Get_OnSuccess_ReturnsStatusCose200()
    {
        // Arrange
        var _controller = new UsersController();

        // Act
        var result = (OkObjectResult) await _controller.Get();

        // Assert
        // result.StatusCode.Should().Be(200); FluentAssertions library
        Assert.That(result.StatusCode, Is.EqualTo(200));


        // Assert.Pass();
    }
}