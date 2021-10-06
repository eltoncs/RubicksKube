namespace RubikCube.Parts
{
    public interface ICubeLine : IRotatable
    {
        ICubeElement BackLine { get; set; }
        ICubeElement FrontLine { get; set; }
        ICubeElement MiddleLine { get; set; }
        ICubeUnit[][] Value { get; set; }
    }
}