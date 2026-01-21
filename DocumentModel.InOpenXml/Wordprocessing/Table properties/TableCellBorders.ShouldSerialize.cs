namespace DocumentModel.Wordprocessing;

public partial class TableCellBorders
{
  public bool ShouldSerializeTopBorder() => TopBorder is not null;
  public bool ShouldSerializeLeftBorder() => LeftBorder is not null;
  public bool ShouldSerializeStartBorder() => StartBorder is not null;
  public bool ShouldSerializeBottomBorder() => BottomBorder is not null;
  public bool ShouldSerializeRightBorder() => RightBorder is not null;
  public bool ShouldSerializeEndBorder() => EndBorder is not null;
  public bool ShouldSerializeInsideHorizontalBorder() => InsideHorizontalBorder is not null;
  public bool ShouldSerializeInsideVerticalBorder() => InsideVerticalBorder is not null;
  public bool ShouldSerializeTopLeftToBottomRightCellBorder() => TopLeftToBottomRightCellBorder is not null;
  public bool ShouldSerializeTopRightToBottomLeftCellBorder() => TopRightToBottomLeftCellBorder is not null;
}
