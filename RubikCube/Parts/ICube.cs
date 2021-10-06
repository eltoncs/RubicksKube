using RubikCube.Parts.Enums;

namespace RubikCube.Parts
{
    public interface ICube
    {
        ICubeLine BottomLine { get; set; }
        ICubeRow LeftRow { get; set; }
        ICubeLine MiddleLine { get; set; }
        ICubeRow MiddleRow { get; set; }
        ICubeRow RightRow { get; set; }
        ICubeLine TopLine { get; set; }

        void Rotate90(FaceSide side, Rotation direction);
        string[][] TakeSnapshot(FaceSide side);
    }
}