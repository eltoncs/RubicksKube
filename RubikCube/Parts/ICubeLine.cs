namespace RubikCube.Parts
{
    public interface ICubeLine : IRotatable
    {
        CubeElement BackLine { get; set; }
        CubeElement FrontLine { get; set; }
        CubeElement MiddleLine { get; set; }
        CubeUnit[][] Value { get; set; }
    }
}