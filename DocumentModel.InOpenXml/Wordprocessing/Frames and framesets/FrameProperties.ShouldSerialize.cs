namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FrameProperties
{
  public bool ShouldSerializeDropCap() => DropCap is not null;
  public bool ShouldSerializeDropCapLines() => DropCapLines is not null;
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializeVerticalSpace() => VerticalSpace is not null;
  public bool ShouldSerializeHorizontalSpace() => HorizontalSpace is not null;
  public bool ShouldSerializeWrap() => Wrap is not null;
  public bool ShouldSerializeHorizontalPosition() => HorizontalPosition is not null;
  public bool ShouldSerializeVerticalPosition() => VerticalPosition is not null;
  public bool ShouldSerializeX() => X is not null;
  public bool ShouldSerializeXAlign() => XAlign is not null;
  public bool ShouldSerializeY() => Y is not null;
  public bool ShouldSerializeYAlign() => YAlign is not null;
  //public bool ShouldSerializeHeightType() => HeightType is not null;
  public bool ShouldSerializeAnchorLock() => AnchorLock is not null;
}
