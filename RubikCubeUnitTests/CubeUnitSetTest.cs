using Microsoft.VisualStudio.TestTools.UnitTesting;
using RubikCube.Parts;
using RubikCube.Parts.Enums;
using System.Drawing;

namespace RubikCubeUnitTests
{
    [TestClass]
    public class CubeUnitSetTest
    {
        [TestMethod]
        public void WhenUnitSetIsCreatedColorsMustBeWellDistributed()
        {
            var cubeLine = new CubeLine();

            Assert.IsTrue(cubeLine.FrontLine.SecondBlock.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeLine.FrontLine.ThirdBlock.Faces[(int)FaceSide.Front].Color == Color.Green);

            Assert.IsTrue(cubeLine.FrontLine.FirstBlock.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeLine.FrontLine.SecondBlock.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeLine.FrontLine.ThirdBlock.Faces[(int)FaceSide.Left].Color == Color.Orange);

            Assert.IsTrue(cubeLine.FrontLine.FirstBlock.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeLine.FrontLine.SecondBlock.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeLine.FrontLine.ThirdBlock.Faces[(int)FaceSide.Back].Color == Color.Blue);

            Assert.IsTrue(cubeLine.FrontLine.FirstBlock.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeLine.FrontLine.SecondBlock.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeLine.FrontLine.ThirdBlock.Faces[(int)FaceSide.Right].Color == Color.Red);

            Assert.IsTrue(cubeLine.FrontLine.FirstBlock.Faces[(int)FaceSide.Top].Color == Color.White);
            Assert.IsTrue(cubeLine.FrontLine.SecondBlock.Faces[(int)FaceSide.Top].Color == Color.White);
            Assert.IsTrue(cubeLine.FrontLine.ThirdBlock.Faces[(int)FaceSide.Top].Color == Color.White);

            Assert.IsTrue(cubeLine.FrontLine.FirstBlock.Faces[(int)FaceSide.Bottom].Color == Color.Yellow);
            Assert.IsTrue(cubeLine.FrontLine.SecondBlock.Faces[(int)FaceSide.Bottom].Color == Color.Yellow);
            Assert.IsTrue(cubeLine.FrontLine.ThirdBlock.Faces[(int)FaceSide.Bottom].Color == Color.Yellow);
        }

        [TestMethod]
        public void WhenUnitSetIsRotatedFrontClockwiseColorsMustBeWellDistributed()
        {
            var cubeLine = new CubeLine();

            cubeLine.Rotate(Rotation.Clockwise);
            AssertRotation(cubeLine.FrontLine, Color.Green, Color.Blue, Color.Yellow, Color.White, Color.Orange, Color.Red);
            
            cubeLine.Rotate(Rotation.Clockwise);
            AssertRotation(cubeLine.FrontLine, Color.Green, Color.Blue, Color.Red, Color.Orange, Color.Yellow, Color.White);

            cubeLine.Rotate(Rotation.Clockwise);
            AssertRotation(cubeLine.FrontLine, Color.Green, Color.Blue, Color.White, Color.Yellow, Color.Red, Color.Orange);

            cubeLine.Rotate(Rotation.Clockwise);
            AssertRotation(cubeLine.FrontLine, Color.Green, Color.Blue, Color.Orange, Color.Red, Color.White, Color.Yellow);
        }

        [TestMethod]
        public void WhenUnitSetIsRotatedFrontAntiClockwiseColorsMustBeWellDistributed()
        {
            var cubeLine = new CubeLine();

            cubeLine.Rotate(Rotation.AntiClockwise);
            AssertRotation(cubeLine.FrontLine, Color.Green, Color.Blue, Color.White, Color.Yellow, Color.Red, Color.Orange);

            cubeLine.Rotate(Rotation.AntiClockwise);
            AssertRotation(cubeLine.FrontLine, Color.Green, Color.Blue, Color.Red, Color.Orange, Color.Yellow, Color.White);

            cubeLine.Rotate(Rotation.AntiClockwise);
            AssertRotation(cubeLine.FrontLine, Color.Green, Color.Blue, Color.Yellow, Color.White, Color.Orange, Color.Red);

            cubeLine.Rotate(Rotation.AntiClockwise);
            AssertRotation(cubeLine.FrontLine, Color.Green, Color.Blue, Color.Orange, Color.Red, Color.White, Color.Yellow);
        }

        [TestMethod]
        public void WhenUnitSetIsRotatedSideClockwiseColorsMustBeWellDistributed()
        {
            var cubeRow = new CubeRow();

            cubeRow.Rotate(Rotation.Clockwise);
            AssertRotation(cubeRow.FrontRow, Color.Yellow, Color.White, Color.Orange, Color.Red, Color.Green, Color.Blue);

            cubeRow.Rotate(Rotation.Clockwise);
            AssertRotation(cubeRow.FrontRow, Color.Blue, Color.Green, Color.Orange, Color.Red, Color.Yellow, Color.White);

            cubeRow.Rotate(Rotation.Clockwise);
            AssertRotation(cubeRow.FrontRow, Color.White, Color.Yellow, Color.Orange, Color.Red, Color.Blue, Color.Green);

            cubeRow.Rotate(Rotation.Clockwise);
            AssertRotation(cubeRow.FrontRow, Color.Green, Color.Blue, Color.Orange, Color.Red, Color.White, Color.Yellow);
        }

        [TestMethod]
        public void WhenUnitSetIsRotatedSideAntiClockwiseColorsMustBeWellDistributed()
        {
            var cubeRow = new CubeRow();

            cubeRow.Rotate(Rotation.AntiClockwise);
            AssertRotation(cubeRow.FrontRow, Color.White, Color.Yellow, Color.Orange, Color.Red, Color.Blue, Color.Green);

            cubeRow.Rotate(Rotation.AntiClockwise);
            AssertRotation(cubeRow.FrontRow, Color.Blue, Color.Green, Color.Orange, Color.Red, Color.Yellow, Color.White);

            cubeRow.Rotate(Rotation.AntiClockwise);
            AssertRotation(cubeRow.FrontRow, Color.Yellow, Color.White, Color.Orange, Color.Red, Color.Green, Color.Blue);

            cubeRow.Rotate(Rotation.AntiClockwise);
            AssertRotation(cubeRow.FrontRow, Color.Green, Color.Blue, Color.Orange, Color.Red, Color.White, Color.Yellow);
        }

        private void AssertRotation(
          CubeElement line,
          Color colorFront,
          Color colorBack,
          Color colorLeft,
          Color colorRight,
          Color colorTop,
          Color colorBottom)
        {
            Assert.IsTrue(line.FirstBlock.Faces[(int)FaceSide.Front].Color == colorFront);
            Assert.IsTrue(line.SecondBlock.Faces[(int)FaceSide.Front].Color == colorFront);
            Assert.IsTrue(line.ThirdBlock.Faces[(int)FaceSide.Front].Color == colorFront);

            Assert.IsTrue(line.FirstBlock.Faces[(int)FaceSide.Back].Color == colorBack);
            Assert.IsTrue(line.SecondBlock.Faces[(int)FaceSide.Back].Color == colorBack);
            Assert.IsTrue(line.ThirdBlock.Faces[(int)FaceSide.Back].Color == colorBack);

            Assert.IsTrue(line.FirstBlock.Faces[(int)FaceSide.Left].Color == colorLeft);
            Assert.IsTrue(line.SecondBlock.Faces[(int)FaceSide.Left].Color == colorLeft);
            Assert.IsTrue(line.ThirdBlock.Faces[(int)FaceSide.Left].Color == colorLeft);

            Assert.IsTrue(line.FirstBlock.Faces[(int)FaceSide.Right].Color == colorRight);
            Assert.IsTrue(line.SecondBlock.Faces[(int)FaceSide.Right].Color == colorRight);
            Assert.IsTrue(line.ThirdBlock.Faces[(int)FaceSide.Right].Color == colorRight);

            Assert.IsTrue(line.FirstBlock.Faces[(int)FaceSide.Top].Color == colorTop);
            Assert.IsTrue(line.SecondBlock.Faces[(int)FaceSide.Top].Color == colorTop);
            Assert.IsTrue(line.ThirdBlock.Faces[(int)FaceSide.Top].Color == colorTop);

            Assert.IsTrue(line.FirstBlock.Faces[(int)FaceSide.Bottom].Color == colorBottom);
            Assert.IsTrue(line.SecondBlock.Faces[(int)FaceSide.Bottom].Color == colorBottom);
            Assert.IsTrue(line.ThirdBlock.Faces[(int)FaceSide.Bottom].Color == colorBottom);
        }
    }
}
