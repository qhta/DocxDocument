namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TablePositionProperties
{
  public bool ShouldSerializeLeftFromText() => LeftFromText is not null && ShouldSerialize(LeftFromText);
  public bool ShouldSerializeRightFromText() => RightFromText is not null && ShouldSerialize(RightFromText);
  public bool ShouldSerializeTopFromText() => TopFromText is not null && ShouldSerialize(TopFromText);
  public bool ShouldSerializeBottomFromText() => BottomFromText is not null && ShouldSerialize(BottomFromText);
  public bool ShouldSerializeVerticalAnchor() => VerticalAnchor is not null && ShouldSerialize(VerticalAnchor);
  public bool ShouldSerializeHorizontalAnchor() => HorizontalAnchor is not null && ShouldSerialize(HorizontalAnchor);
  public bool ShouldSerializeTablePositionXAlignment() => TablePositionXAlignment is not null && ShouldSerialize(TablePositionXAlignment);
  public bool ShouldSerializeTablePositionX() => TablePositionX is not null && ShouldSerialize(TablePositionX);
  public bool ShouldSerializeTablePositionYAlignment() => TablePositionYAlignment is not null && ShouldSerialize(TablePositionYAlignment);
  public bool ShouldSerializeTablePositionY() => TablePositionY is not null && ShouldSerialize(TablePositionY);
}
