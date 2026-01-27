namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class EquationArray
{
  public bool ShouldSerializeEquationArrayProperties() => EquationArrayProperties is not null;
}
