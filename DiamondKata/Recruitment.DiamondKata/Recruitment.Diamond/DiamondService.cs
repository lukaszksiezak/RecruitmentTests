using Recruitment.Diamond.Presenters;

namespace Recruitment.Diamond
{
    public class DiamondService
    {
        private readonly IDiamondGenerator _diamondGenerator;
        private readonly IPresenter _presenter;

        public DiamondService(IDiamondGenerator diamondGenerator, IPresenter presenter)
        {
            _diamondGenerator = diamondGenerator;
            _presenter = presenter;
        }

        public void GenerateDiamond(char middleLetter)
        {
            var diamond = _diamondGenerator.Generate(middleLetter);
            _presenter.Print(diamond);
        }
    }
}
