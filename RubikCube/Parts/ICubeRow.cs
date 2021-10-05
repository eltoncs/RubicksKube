namespace RubikCube.Parts
{
    public interface ICubeRow : IRotatable
    {
        CubeElement BackRow { get; set; }
        CubeElement FrontRow { get; set; }
        CubeElement MiddleRow { get; set; }
    }
}