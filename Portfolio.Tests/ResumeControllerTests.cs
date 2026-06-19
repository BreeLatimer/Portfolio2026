using Microsoft.AspNetCore.Mvc;
using Xunit;
using Portfolio.Controllers;

namespace Portfolio.Tests;

public class ResumeControllerTests
{
    [Fact]
    public void Index_ReturnsViewResult_ForResumePage()
    {
        // Arrange
        // We try to instantiate a controller that we haven't built yet
        var controller = new ResumeController();

        // Act
        var result = controller.Index();

        // Assert
        Assert.IsType<ViewResult>(result);
    }
}