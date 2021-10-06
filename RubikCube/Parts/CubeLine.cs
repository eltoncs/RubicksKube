using RubikCube.Parts.Enums;
using System;

namespace RubikCube.Parts
{
    [Serializable]
    public class CubeLine : ICubeLine
    {
        public ICubeUnit[][] Value { get; set; }

        public ICubeElement FrontLine { get; set; }
        public ICubeElement MiddleLine { get; set; }
        public ICubeElement BackLine { get; set; }

        public CubeLine()
        {
            Value = new CubeUnit[3][];
            Value[0] = new CubeUnit[3];
            Value[1] = new CubeUnit[3];
            Value[2] = new CubeUnit[3];

            this.Initialize();
            this.UpdateLines();
        }

        public void Rotate(Rotation direction)
        {
            this.RotateAllBlocksInLine(this, direction);
            this.UpdateLines();
        }

        private void Initialize()
        {
            for (var x1 = 0; x1 < Value.Length; x1++)
            {
                for (var x2 = 0; x2 < Value.Length; x2++)
                {
                    Value[x1][x2] = new CubeUnit();
                }
            }
        }

        private void RotateAllBlocksInLine(ICubeLine line, Rotation direction)
        {
            for (var x = 0; x < line.Value.Length; x++)
            {
                for (var y = 0; y < line.Value.Length; y++)
                {
                    line.Value[x][y].RotateFront(direction);
                }
            }
        }

        private void UpdateLines()
        {
            FrontLine = new CubeElement(this.Value[0][0], this.Value[0][1], this.Value[0][2]);
            MiddleLine = new CubeElement(this.Value[1][0], this.Value[1][1], this.Value[1][2]);
            BackLine = new CubeElement(this.Value[2][0], this.Value[2][1], this.Value[2][2]);
        }
    }
}
