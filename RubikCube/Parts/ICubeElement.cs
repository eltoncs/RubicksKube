using RubikCube.Parts.Enums;

namespace RubikCube.Parts
{
    public interface ICubeElement
    {
        ICubeUnit FirstBlock { get; set; }
        ICubeUnit SecondBlock { get; set; }
        ICubeUnit ThirdBlock { get; set; }

        void RotateFront(Rotation direction);
        void RotateSide(Rotation direction);
    }
}