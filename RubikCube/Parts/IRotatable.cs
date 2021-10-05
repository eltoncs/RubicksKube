using RubikCube.Parts.Enums;

namespace RubikCube.Parts
{
    public interface IRotatable
    {
        void Rotate(Rotation direction);
    }
}
