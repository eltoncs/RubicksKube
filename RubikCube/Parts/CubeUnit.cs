using RubikCube.Parts.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RubikCube.Parts
{
    [Serializable]
    public class CubeUnit : ICubeUnit
    {
        public List<UnitFace> Faces { get; set; }

        public CubeUnit()
        {
            Faces = new List<UnitFace>();

            var faceFront = new UnitFace(Enums.FaceSide.Front, Color.Green);
            var faceBack = new UnitFace(Enums.FaceSide.Back, Color.Blue);
            var faceLeft = new UnitFace(Enums.FaceSide.Left, Color.Orange);
            var faceRight = new UnitFace(Enums.FaceSide.Right, Color.Red);
            var faceTop = new UnitFace(Enums.FaceSide.Top, Color.White);
            var faceBottom = new UnitFace(Enums.FaceSide.Bottom, Color.Yellow);

            Faces.Add(faceFront);
            Faces.Add(faceLeft);
            Faces.Add(faceBack);
            Faces.Add(faceRight);
            Faces.Add(faceTop);
            Faces.Add(faceBottom);
        }

        public void RotateFront(Rotation orientation)
        {
            var unitClone = this.Clone();

            if (orientation == Rotation.Clockwise)
            {
                Faces[(int)FaceSide.Top].Color = unitClone.Faces[(int)FaceSide.Left].Color;
                Faces[(int)FaceSide.Left].Color = unitClone.Faces[(int)FaceSide.Bottom].Color;
                Faces[(int)FaceSide.Bottom].Color = unitClone.Faces[(int)FaceSide.Right].Color;
                Faces[(int)FaceSide.Right].Color = unitClone.Faces[(int)FaceSide.Top].Color;

                return;
            }

            Faces[(int)FaceSide.Top] = unitClone.Faces[(int)FaceSide.Right];
            Faces[(int)FaceSide.Right] = unitClone.Faces[(int)FaceSide.Bottom];
            Faces[(int)FaceSide.Bottom] = unitClone.Faces[(int)FaceSide.Left];
            Faces[(int)FaceSide.Left] = unitClone.Faces[(int)FaceSide.Top];

            return;
        }

        public void RotateSide(Rotation orientation)
        {
            var unitClone = this.Clone();

            if (orientation == Rotation.Clockwise)
            {
                Faces[(int)FaceSide.Front].Color = unitClone.Faces[(int)FaceSide.Bottom].Color;
                Faces[(int)FaceSide.Bottom].Color = unitClone.Faces[(int)FaceSide.Back].Color;
                Faces[(int)FaceSide.Back].Color = unitClone.Faces[(int)FaceSide.Top].Color;
                Faces[(int)FaceSide.Top].Color = unitClone.Faces[(int)FaceSide.Front].Color;

                return;
            }

            Faces[(int)FaceSide.Front].Color = unitClone.Faces[(int)FaceSide.Top].Color;
            Faces[(int)FaceSide.Top].Color = unitClone.Faces[(int)FaceSide.Back].Color;
            Faces[(int)FaceSide.Back].Color = unitClone.Faces[(int)FaceSide.Bottom].Color;
            Faces[(int)FaceSide.Bottom].Color = unitClone.Faces[(int)FaceSide.Front].Color;

            return;
        }

        public CubeUnit Clone()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;
                return (CubeUnit)formatter.Deserialize(ms);
            }
        }
    }
}
