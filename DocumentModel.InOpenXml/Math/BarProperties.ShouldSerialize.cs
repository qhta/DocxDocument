namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class BarProperties
{
  public bool ShouldSerializePosition() => Position is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
