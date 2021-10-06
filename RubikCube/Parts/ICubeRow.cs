namespace RubikCube.Parts
{
    public interface ICubeRow : IRotatable
    {
        ICubeElement BackRow { get; set; }
        ICubeElement FrontRow { get; set; }
        ICubeElement MiddleRow { get; set; }
    }
}