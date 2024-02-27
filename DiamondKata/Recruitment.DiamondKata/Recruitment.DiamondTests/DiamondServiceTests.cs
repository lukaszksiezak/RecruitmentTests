using Moq;
using Recruitment.Diamond;
using Recruitment.Diamond.Presenters;
using Xunit;

namespace Recruitment.DiamondTests
{
    public class DiamondServiceTests
    {
        [Fact]
        public void DiamondServiceTest_ShouldPrintDiamondOnce()
        {
            //Arrange
            var diamondGeneratorMock = new Mock<IDiamondGenerator>();
            diamondGeneratorMock.Setup(d => d.Generate(It.IsAny<char>())).Returns(It.IsAny<string>());

            var printerMock = new Mock<IPresenter>();
            printerMock.Setup(p => p.Print(It.IsAny<string>())).Verifiable();

            var diamondService = new DiamondService(new DiamondGenerator(), printerMock.Object);

            //Act
            diamondService.GenerateDiamond(It.IsAny<char>());

            //Assert
            printerMock.Verify(p => p.Print(It.IsAny<string>()), Times.Once);
        }
    }
}
