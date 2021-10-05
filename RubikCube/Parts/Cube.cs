using RubikCube.Parts.Enums;

namespace RubikCube.Parts
{
    public class Cube : ICube
    {
        public CubeLine TopLine { get; set; }
        public CubeLine MiddleLine { get; set; }
        public CubeLine BottomLine { get; set; }

        public CubeRow LeftRow { get; set; }
        public CubeRow MiddleRow { get; set; }
        public CubeRow RightRow { get; set; }

        public Cube()
        {
            TopLine = new CubeLine();
            MiddleLine = new CubeLine();
            BottomLine = new CubeLine();

            LeftRow = new CubeRow(TopLine, MiddleLine, BottomLine, 0);
            MiddleRow = new CubeRow(TopLine, MiddleLine, BottomLine, 1);
            RightRow = new CubeRow(TopLine, MiddleLine, BottomLine, 2);
        }

        public void Rotate90(FaceSide side, Rotation direction)
        {
            switch (side)
            {
                case FaceSide.Front:
                    RotateFrontFace(direction);
                    break;
                case FaceSide.Back:
                    RotateBackFace(direction);
                    break;
                case FaceSide.Right:
                    RotateRightFace(direction);
                    break;
                case FaceSide.Left:
                    //RotateLeftFace(direction);
                    break;
            }
        }

        public string[][] TakeSnapshot(FaceSide side)
        {
            switch (side)
            {
                case FaceSide.Front:
                    return TakeFrontSideSnapshot();
                case FaceSide.Right:
                    return TakeRightSideSnapshot();
                case FaceSide.Left:
                    return TakeLeftSideSnapshot();
                case FaceSide.Back:
                    return TakeBackSideSnapshot();
                case FaceSide.Top:
                    return TakeTopSideSnapshot();
                case FaceSide.Bottom:
                    return TakeBottomSideSnapshot();
            }

            return null;
        }

        private void RotateFrontFace(Rotation direction)
        {
            this.TopLine.FrontLine.RotateFront(direction);
            this.MiddleLine.FrontLine.RotateFront(direction);
            this.BottomLine.FrontLine.RotateFront(direction);
        }

        private void RotateRightFace(Rotation direction)
        {
            this.RightRow.FrontRow.RotateSide(direction);
            this.RightRow.MiddleRow.RotateSide(direction);
            this.RightRow.BackRow.RotateSide(direction);
        }

        private void RotateBackFace(Rotation direction)
        {
            this.TopLine.BackLine.RotateFront(direction);
            this.MiddleLine.BackLine.RotateFront(direction);
            this.BottomLine.BackLine.RotateFront(direction);
        }

        private string[][] TakeFrontSideSnapshot()
        {
            var snapshot = new string[3][];
            snapshot[0] = new string[3];
            snapshot[1] = new string[3];
            snapshot[2] = new string[3];

            for (var x = 0; x < 3; x++)
            {
                snapshot[0][x] = TopLine.Value[0][x].Faces[(int)FaceSide.Front].Color.ToString().Substring(7).Replace("]", "");
                snapshot[1][x] = MiddleLine.Value[0][x].Faces[(int)FaceSide.Front].Color.ToString().Substring(7).Replace("]", "");
                snapshot[2][x] = BottomLine.Value[0][x].Faces[(int)FaceSide.Front].Color.ToString().Substring(7).Replace("]", "");
            }

            return snapshot;
        }

        private string[][] TakeRightSideSnapshot()
        {
            var snapshot = new string[3][];
            snapshot[0] = new string[3];
            snapshot[1] = new string[3];
            snapshot[2] = new string[3];

            var iteration = new int[3] { 2, 1, 2 };

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    snapshot[x][y] = TopLine.Value[x][iteration[y]].Faces[(int)FaceSide.Right].Color.ToString().Substring(7).Replace("]", "");
                    snapshot[x][y] = MiddleLine.Value[x][iteration[y]].Faces[(int)FaceSide.Right].Color.ToString().Substring(7).Replace("]", "");
                    snapshot[x][y] = BottomLine.Value[x][iteration[y]].Faces[(int)FaceSide.Right].Color.ToString().Substring(7).Replace("]", "");
                }
            }

            return snapshot;
        }

        private string[][] TakeLeftSideSnapshot()
        {
            var snapshot = new string[3][];
            snapshot[0] = new string[3];
            snapshot[1] = new string[3];
            snapshot[2] = new string[3];

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    snapshot[x][y] = TopLine.Value[y][0].Faces[(int)FaceSide.Left].Color.ToString().ToString().Substring(7).Replace("]", "");
                    snapshot[x][y] = MiddleLine.Value[y][0].Faces[(int)FaceSide.Left].Color.ToString().ToString().Substring(7).Replace("]", "");
                    snapshot[x][y] = BottomLine.Value[y][0].Faces[(int)FaceSide.Left].Color.ToString().ToString().Substring(7).Replace("]", "");
                }
            }

            return snapshot;
        }

        private string[][] TakeBackSideSnapshot()
        {
            var snapshot = new string[3][];
            snapshot[0] = new string[3];
            snapshot[1] = new string[3];
            snapshot[2] = new string[3];

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    snapshot[x][y] = TopLine.Value[2][y].Faces[(int)FaceSide.Back].Color.ToString().ToString().Substring(7).Replace("]", "");
                    snapshot[x][y] = MiddleLine.Value[2][y].Faces[(int)FaceSide.Back].Color.ToString().ToString().Substring(7).Replace("]", "");
                    snapshot[x][y] = BottomLine.Value[2][y].Faces[(int)FaceSide.Back].Color.ToString().ToString().Substring(7).Replace("]", "");
                }
            }

            return snapshot;
        }

        private string[][] TakeTopSideSnapshot()
        {
            var snapshot = new string[3][];
            snapshot[0] = new string[3];
            snapshot[1] = new string[3];
            snapshot[2] = new string[3];

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    snapshot[x][y] = TopLine.Value[x][y].Faces[(int)FaceSide.Top].Color.ToString().ToString().Substring(7).Replace("]", "");
                }
            }

            return snapshot;
        }

        private string[][] TakeBottomSideSnapshot()
        {
            var snapshot = new string[3][];
            snapshot[0] = new string[3];
            snapshot[1] = new string[3];
            snapshot[2] = new string[3];

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    snapshot[x][y] = BottomLine.Value[x][y].Faces[(int)FaceSide.Bottom].Color.ToString().ToString().Substring(7).Replace("]", "");
                }
            }

            return snapshot;
        }
    }
}
