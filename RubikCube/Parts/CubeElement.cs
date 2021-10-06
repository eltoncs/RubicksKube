using RubikCube.Parts.Enums;
using System;

namespace RubikCube.Parts
{
    [Serializable]
    public class CubeElement : ICubeElement
    {
        public ICubeUnit FirstBlock { get; set; }
        public ICubeUnit SecondBlock { get; set; }
        public ICubeUnit ThirdBlock { get; set; }

        public CubeElement()
        {
        }

        public CubeElement(ICubeUnit firstBlock, ICubeUnit secondBlock, ICubeUnit thirdBlock)
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
