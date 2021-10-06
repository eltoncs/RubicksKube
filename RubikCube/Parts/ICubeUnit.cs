using RubikCube.Parts.Enums;
using System.Collections.Generic;

namespace RubikCube.Parts
{
    public interface ICubeUnit
    {
        List<IUnitFace> Faces { get; set; }

        void RotateFront(Rotation orientation);
        void RotateSide(Rotation orientation);
    }
}