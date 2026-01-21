namespace DocumentModel.Math;

public partial class GroupCharProperties
{
  public bool ShouldSerializeAccentChar() => AccentChar is not null;
  public bool ShouldSerializePosition() => Position is not null;
  public bool ShouldSerializeVerticalJustification() => VerticalJustification is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
