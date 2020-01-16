using Xunit;
using Egil.RazorComponents.Testing;
using ArtOfElectronics.Presentation.Pages.Resistors.Calculate;
using Egil.RazorComponents.Testing.EventDispatchExtensions;
using System;

namespace ArtOfElectronics.Presentation.Test
{
    public class ParallelPageTests : ComponentTestFixture
    {
        [Fact]
        public void CorrectResultFrom1ResistorValue()
        {
            // Arrange
            var renderedComponent = RenderComponent<Parallel>();

            // Act
            renderedComponent.Find("#resistor-input-0").Change("5000");
            renderedComponent.Find("#calculate").Click();

            // Assert
            var result = renderedComponent.Find("#result").TextContent.Trim().Trim(Environment.NewLine.ToCharArray());
            Assert.Equal("5000.000 Ω", result);
        }

        [Fact]
        public void CorrectResultFrom2ResistorValues()
        {
            // Arrange
            var renderedComponent = RenderComponent<Parallel>();

            // Act
            renderedComponent.Find("#add").Click();
            renderedComponent.Find("#resistor-input-0").Change("5000");
            renderedComponent.Find("#resistor-input-1").Change("10000");
            renderedComponent.Find("#calculate").Click();

            // Assert
            var result = renderedComponent.Find("#result").TextContent.Trim();
            Assert.Equal("3333.333 Ω", result);
        }

        [Fact]
        public void CorrectResultFrom3ResistorValues()
        {
            // Arrange
            var renderedComponent = RenderComponent<Parallel>();

            // Act
            renderedComponent.Find("#add").Click();
            renderedComponent.Find("#add").Click();
            renderedComponent.Find("#resistor-input-0").Change("5000");
            renderedComponent.Find("#resistor-input-1").Change("10000");
            renderedComponent.Find("#resistor-input-2").Change("10000");
            renderedComponent.Find("#calculate").Click();

            // Assert
            var result = renderedComponent.Find("#result").TextContent.Trim();
            Assert.Equal("2500.000 Ω", result);
        }
    }
}
