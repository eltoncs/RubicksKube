using RubikCube.Parts.Enums;
using System.Collections.Generic;

namespace RubikCube.Parts
{
    public interface ICubeUnit
    {
        List<UnitFace> Faces { get; set; }

        CubeUnit Clone();
        void RotateFront(Rotation orientation);
        void RotateSide(Rotation orientation);
    }
}