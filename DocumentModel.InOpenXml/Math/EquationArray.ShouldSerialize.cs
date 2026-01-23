namespace DocumentModel.Math;

public partial class EquationArray
{
  public bool ShouldSerializeEquationArrayProperties() => EquationArrayProperties is not null;
}
