using Microsoft.VisualStudio.TestTools.UnitTesting;
using RubikCube.Parts;
using RubikCube.Parts.Enums;
using System.Drawing;

namespace RubikCubeUnitTests
{
    [TestClass]
    public class CubeUnitTest
    {
        [TestMethod]
        public void WhenUnitIsCreatedColorsMustBeWellDistributed()
        {
            var cubeUnit = new CubeUnit();

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Yellow);
        }

        [TestMethod]
        public void WhenUnitIsRotateFrontClockwiseColorsMustBeWellDistributed()
        {
            var cubeUnit = new CubeUnit();

            cubeUnit.RotateFront(Rotation.Clockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Red);

            cubeUnit.RotateFront(Rotation.Clockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.White);

            cubeUnit.RotateFront(Rotation.Clockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Orange);

            cubeUnit.RotateFront(Rotation.Clockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Yellow);
        }

        [TestMethod]
        public void WhenUnitIsRotateFrontAntiClockwiseColorsMustBeWellDistributed()
        {
            var cubeUnit = new CubeUnit();

            cubeUnit.RotateFront(Rotation.AntiClockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Orange);

            cubeUnit.RotateFront(Rotation.AntiClockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.White);

            cubeUnit.RotateFront(Rotation.AntiClockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Red);

            cubeUnit.RotateFront(Rotation.AntiClockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Yellow);
        }

        [TestMethod]
        public void WhenUnitIsRotateSideClockwiseColorsMustBeWellDistributed()
        {
            var cubeUnit = new CubeUnit();

            cubeUnit.RotateSide(Rotation.Clockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Blue);

            cubeUnit.RotateSide(Rotation.Clockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.White);

            cubeUnit.RotateSide(Rotation.Clockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Green);

            cubeUnit.RotateSide(Rotation.Clockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Yellow);
        }

        [TestMethod]
        public void WhenUnitIsRotateSideAntiClockwiseColorsMustBeWellDistributed()
        {
            var cubeUnit = new CubeUnit();

            cubeUnit.RotateSide(Rotation.AntiClockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Green);

            cubeUnit.RotateSide(Rotation.AntiClockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.White);

            cubeUnit.RotateSide(Rotation.AntiClockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Yellow);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Blue);

            cubeUnit.RotateSide(Rotation.AntiClockwise);

            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Front].Color == Color.Green);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Left].Color == Color.Orange);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Back].Color == Color.Blue);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Right].Color == Color.Red);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Top].Color == Color.White);
            Assert.IsTrue(cubeUnit.Faces[(int)FaceSide.Bottom].Color == Color.Yellow);
        }
    }
}
