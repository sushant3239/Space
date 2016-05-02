using Cirrious.MvvmCross.ViewModels;
using Test.Core.Model;
using Test.Core.Service;

namespace Test.Core
{
    public class SpaceViewModel : MvxViewModel
    {
        private ISpaceService _spaceService;

        public SpaceViewModel(ISpaceService spaceService)
        {
            _spaceService = spaceService;
            SpaceView = _spaceService.GetSpaceViewById(2);
        }
        public SpaceView SpaceView { get; set; }
    }
}
