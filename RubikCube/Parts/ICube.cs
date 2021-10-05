using RubikCube.Parts.Enums;

namespace RubikCube.Parts
{
    public interface ICube
    {
        CubeLine BottomLine { get; set; }
        CubeRow LeftRow { get; set; }
        CubeLine MiddleLine { get; set; }
        CubeRow MiddleRow { get; set; }
        CubeRow RightRow { get; set; }
        CubeLine TopLine { get; set; }

        void Rotate90(FaceSide side, Rotation direction);
        string[][] TakeSnapshot(FaceSide side);
    }
}