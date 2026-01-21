namespace DocumentModel.Math;

public partial class BarProperties
{
  public bool ShouldSerializePosition() => Position is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
