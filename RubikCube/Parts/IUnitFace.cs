using RubikCube.Parts.Enums;
using System.Drawing;

namespace RubikCube.Parts
{
    public interface IUnitFace
    {
        Color Color { get; set; }
        FaceSide Side { get; set; }
    }
}