namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class TablePositionProperties
{
  public bool ShouldSerializeLeftFromText() => LeftFromText is not null;
  public bool ShouldSerializeRightFromText() => RightFromText is not null;
  public bool ShouldSerializeTopFromText() => TopFromText is not null;
  public bool ShouldSerializeBottomFromText() => BottomFromText is not null;
  public bool ShouldSerializeVerticalAnchor() => VerticalAnchor is not null;
  public bool ShouldSerializeHorizontalAnchor() => HorizontalAnchor is not null;
  public bool ShouldSerializeTablePositionXAlignment() => TablePositionXAlignment is not null;
  public bool ShouldSerializeTablePositionX() => TablePositionX is not null;
  public bool ShouldSerializeTablePositionYAlignment() => TablePositionYAlignment is not null;
  public bool ShouldSerializeTablePositionY() => TablePositionY is not null;
}
