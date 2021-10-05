using Microsoft.VisualStudio.TestTools.UnitTesting;
using RubikCube.Parts;
using RubikCube.Parts.Enums;

namespace RubikCubeUnitTests
{
    [TestClass]
    public class CubeTest
    {
        [TestMethod]
        public void MainTest()
        {
            var cube = new Cube();
            var frontFace = cube.TakeSnapshot(FaceSide.Front);
            cube.Rotate90(FaceSide.Front, Rotation.Clockwise);
            frontFace = cube.TakeSnapshot(FaceSide.Front);
            cube.Rotate90(FaceSide.Right, Rotation.AntiClockwise);

            frontFace = cube.TakeSnapshot(FaceSide.Front);
            var rightFace = cube.TakeSnapshot(FaceSide.Right);
            var leftFace = cube.TakeSnapshot(FaceSide.Left);
            var backFace = cube.TakeSnapshot(FaceSide.Back);
            var topFace = cube.TakeSnapshot(FaceSide.Top);
            var bottomFace = cube.TakeSnapshot(FaceSide.Bottom);
        }

        [TestMethod]
        public void WhenUnitIsCreatedColorsMustBeWellDistributed()
        {
            var cube = new Cube();

            var frontFace = cube.TakeSnapshot(FaceSide.Front);
            var rightFace = cube.TakeSnapshot(FaceSide.Right);
            var leftFace = cube.TakeSnapshot(FaceSide.Left);
            var backFace = cube.TakeSnapshot(FaceSide.Back);
            var topFace = cube.TakeSnapshot(FaceSide.Top);
            var bottomFace = cube.TakeSnapshot(FaceSide.Bottom);


            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    Assert.IsTrue(frontFace[x][y] == "Green");
                    Assert.IsTrue(rightFace[x][y] == "Red");
                    Assert.IsTrue(leftFace[x][y] == "Orange");
                    Assert.IsTrue(backFace[x][y] == "Blue");
                    Assert.IsTrue(topFace[x][y] == "White");
                    Assert.IsTrue(bottomFace[x][y] == "Yellow");
                }
            }
            
        }
    }
}
