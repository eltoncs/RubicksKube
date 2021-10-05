using RubikCube.Parts.Enums;

namespace RubikCube.Parts
{
    public interface ICubeRow
    {
        CubeElement BackRow { get; set; }
        CubeElement FrontRow { get; set; }
        CubeElement MiddleRow { get; set; }

        void Rotate(Rotation direction);
    }
}