using RubikCube.Parts.Enums;
using System;
using System.Drawing;

namespace RubikCube.Parts
{
    [Serializable]
    public class UnitFace : IUnitFace
    {
        public FaceSide Side { get; set; }
        public Color Color { get; set; }

        public UnitFace(FaceSide side, Color color)
        {
            Side = side;
            Color = color;
        }
    }
}
