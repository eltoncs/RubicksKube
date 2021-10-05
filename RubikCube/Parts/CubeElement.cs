using RubikCube.Parts.Enums;
using System;

namespace RubikCube.Parts
{
    [Serializable]
    public class CubeElement : ICubeElement
    {
        public CubeUnit FirstBlock { get; set; }
        public CubeUnit SecondBlock { get; set; }
        public CubeUnit ThirdBlock { get; set; }

        public CubeElement()
        {
        }

        public CubeElement(CubeUnit firstBlock, CubeUnit secondBlock, CubeUnit thirdBlock)
        {
            this.FirstBlock = firstBlock;
            this.SecondBlock = secondBlock;
            this.ThirdBlock = thirdBlock;
        }

        public void RotateFront(Rotation direction)
        {
            this.FirstBlock.RotateFront(direction);
            this.SecondBlock.RotateFront(direction);
            this.ThirdBlock.RotateFront(direction);
        }

        public void RotateSide(Rotation direction)
        {
            this.FirstBlock.RotateSide(direction);
            this.SecondBlock.RotateSide(direction);
            this.ThirdBlock.RotateSide(direction);
        }

    }
}
