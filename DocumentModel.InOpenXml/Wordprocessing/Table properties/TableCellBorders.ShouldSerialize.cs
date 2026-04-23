namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableCellBorders
{
  public bool ShouldSerializeTopBorder() => TopBorder is not null && ShouldSerialize(TopBorder);
  public bool ShouldSerializeLeftBorder() => LeftBorder is not null && ShouldSerialize(LeftBorder);
  public bool ShouldSerializeStartBorder() => StartBorder is not null && ShouldSerialize(StartBorder);
  public bool ShouldSerializeBottomBorder() => BottomBorder is not null && ShouldSerialize(BottomBorder);
  public bool ShouldSerializeRightBorder() => RightBorder is not null && ShouldSerialize(RightBorder);
  public bool ShouldSerializeEndBorder() => EndBorder is not null && ShouldSerialize(EndBorder);
  public bool ShouldSerializeInsideHorizontalBorder() => InsideHorizontalBorder is not null && ShouldSerialize(InsideHorizontalBorder);
  public bool ShouldSerializeInsideVerticalBorder() => InsideVerticalBorder is not null && ShouldSerialize(InsideVerticalBorder);
  public bool ShouldSerializeTopLeftToBottomRightCellBorder() => TopLeftToBottomRightCellBorder is not null && ShouldSerialize(TopLeftToBottomRightCellBorder);
  public bool ShouldSerializeTopRightToBottomLeftCellBorder() => TopRightToBottomLeftCellBorder is not null && ShouldSerialize(TopRightToBottomLeftCellBorder);
}
