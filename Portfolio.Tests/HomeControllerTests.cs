using Microsoft.AspNetCore.Mvc;
using Xunit;
using Portfolio.Controllers; // Matches the namespace of your main app

namespace Portfolio.Tests;

public class HomeControllerTests
{
    [Fact]
    public void Index_Action_Returns_Correct_View_Result()
    {
        // Arrange
        var controller = new HomeController();

        // Act
        var result = controller.Index();

        // Assert
        Assert.IsType<ViewResult>(result);
    }
}
