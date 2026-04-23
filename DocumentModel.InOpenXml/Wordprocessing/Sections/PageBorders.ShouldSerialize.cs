namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PageBorders
{
  public bool ShouldSerializeZOrder() => ZOrder is not null && ShouldSerialize(ZOrder);
  public bool ShouldSerializeDisplay() => Display is not null && ShouldSerialize(Display);
  public bool ShouldSerializeOffsetFrom() => OffsetFrom is not null && ShouldSerialize(OffsetFrom);
  public bool ShouldSerializeTopBorder() => TopBorder is not null && ShouldSerialize(TopBorder);
  public bool ShouldSerializeLeftBorder() => LeftBorder is not null && ShouldSerialize(LeftBorder);
  public bool ShouldSerializeBottomBorder() => BottomBorder is not null && ShouldSerialize(BottomBorder);
  public bool ShouldSerializeRightBorder() => RightBorder is not null && ShouldSerialize(RightBorder);
}
