using RubikCube.Parts.Enums;

namespace RubikCube.Parts
{
    public class CubeRow : ICubeRow
    {
        public ICubeElement FrontRow { get; set; }
        public ICubeElement MiddleRow { get; set; }
        public ICubeElement BackRow { get; set; }

        public CubeRow()
        {
            this.Initialize();
        }

        public CubeRow(ICubeLine topLine, ICubeLine middleLine, ICubeLine bottomLine, int index)
        {
            this.Initialize();

            FrontRow.FirstBlock = topLine.Value[0][index];
            FrontRow.SecondBlock = middleLine.Value[0][index];
            FrontRow.ThirdBlock = bottomLine.Value[0][index];

            MiddleRow.FirstBlock = topLine.Value[1][index];
            MiddleRow.SecondBlock = middleLine.Value[1][index];
            MiddleRow.ThirdBlock = bottomLine.Value[1][index];

            BackRow.FirstBlock = topLine.Value[2][index];
            BackRow.SecondBlock = middleLine.Value[2][index];
            BackRow.ThirdBlock = bottomLine.Value[2][index];
        }

        public void Rotate(Rotation direction)
        {
            FrontRow.RotateSide(direction);
            MiddleRow.RotateSide(direction);
            BackRow.RotateSide(direction);
        }

        private void Initialize()
        {
            FrontRow = new CubeElement();
            MiddleRow = new CubeElement();
            BackRow = new CubeElement();

            FrontRow.FirstBlock = new CubeUnit();
            FrontRow.SecondBlock = new CubeUnit();
            FrontRow.ThirdBlock = new CubeUnit();

            MiddleRow.FirstBlock = new CubeUnit();
            MiddleRow.SecondBlock = new CubeUnit();
            MiddleRow.ThirdBlock = new CubeUnit();

            BackRow.FirstBlock = new CubeUnit();
            BackRow.SecondBlock = new CubeUnit();
            BackRow.ThirdBlock = new CubeUnit();
        }
    }
}
