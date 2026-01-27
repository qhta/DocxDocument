namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Denominator
{
  public bool ShouldSerializeArgumentProperties() => ArgumentProperties is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
