namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Degree
{
  public bool ShouldSerializeArgumentProperties() => ArgumentProperties is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
