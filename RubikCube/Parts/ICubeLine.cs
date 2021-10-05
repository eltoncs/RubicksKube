using RubikCube.Parts.Enums;

namespace RubikCube.Parts
{
    public interface ICubeLine
    {
        CubeElement BackLine { get; set; }
        CubeElement FrontLine { get; set; }
        CubeElement MiddleLine { get; set; }
        CubeUnit[][] Value { get; set; }

        void Rotate(Rotation direction);
    }
}