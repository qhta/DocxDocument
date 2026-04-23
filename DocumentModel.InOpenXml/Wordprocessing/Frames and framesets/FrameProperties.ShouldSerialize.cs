namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FrameProperties
{
  public bool ShouldSerializeDropCap() => DropCap is not null && ShouldSerialize(DropCap);
  public bool ShouldSerializeDropCapLines() => DropCapLines is not null && ShouldSerialize(DropCapLines);
  public bool ShouldSerializeWidth() => Width is not null && ShouldSerialize(Width);
  public bool ShouldSerializeHeight() => Height is not null && ShouldSerialize(Height);
  public bool ShouldSerializeVerticalSpace() => VerticalSpace is not null && ShouldSerialize(VerticalSpace);
  public bool ShouldSerializeHorizontalSpace() => HorizontalSpace is not null && ShouldSerialize(HorizontalSpace);
  public bool ShouldSerializeWrap() => Wrap is not null && ShouldSerialize(Wrap);
  public bool ShouldSerializeHorizontalPosition() => HorizontalPosition is not null && ShouldSerialize(HorizontalPosition);
  public bool ShouldSerializeVerticalPosition() => VerticalPosition is not null && ShouldSerialize(VerticalPosition);
  public bool ShouldSerializeX() => X is not null && ShouldSerialize(X);
  public bool ShouldSerializeXAlign() => XAlign is not null && ShouldSerialize(XAlign);
  public bool ShouldSerializeY() => Y is not null && ShouldSerialize(Y);
  public bool ShouldSerializeYAlign() => YAlign is not null && ShouldSerialize(YAlign);
  public bool ShouldSerializeAnchorLock() => AnchorLock is not null;
}
