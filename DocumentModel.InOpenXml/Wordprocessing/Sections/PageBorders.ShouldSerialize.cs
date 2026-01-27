namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PageBorders
{
  public bool ShouldSerializeZOrder() => ZOrder is not null;
  public bool ShouldSerializeDisplay() => Display is not null;
  public bool ShouldSerializeOffsetFrom() => OffsetFrom is not null;
  public bool ShouldSerializeTopBorder() => TopBorder is not null;
  public bool ShouldSerializeLeftBorder() => LeftBorder is not null;
  public bool ShouldSerializeBottomBorder() => BottomBorder is not null;
  public bool ShouldSerializeRightBorder() => RightBorder is not null;
}
