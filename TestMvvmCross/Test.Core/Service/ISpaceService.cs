using Test.Core.Model;

namespace Test.Core.Service
{
    public interface ISpaceService
    {
        SpaceView GetSpaceViewById(int id);
    }
}
