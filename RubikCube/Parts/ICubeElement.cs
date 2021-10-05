using RubikCube.Parts.Enums;

namespace RubikCube.Parts
{
    public interface ICubeElement
    {
        CubeUnit FirstBlock { get; set; }
        CubeUnit SecondBlock { get; set; }
        CubeUnit ThirdBlock { get; set; }

        void RotateFront(Rotation direction);
        void RotateSide(Rotation direction);
    }
}