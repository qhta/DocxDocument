namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BaseTableRowProperties
{
  public bool ShouldSerializeRowHeight() => RowHeight is not null;
  public bool ShouldSerializeCantSplit() => CantSplit is not null;
  public bool ShouldSerializeIsHeader() => IsHeader is not null;
  public bool ShouldSerializeRowAlignment() => RowAlignment is not null;
  public bool ShouldSerializeCellSpacing() => CellSpacing is not null;
  public bool ShouldSerializeGlyphHidden() => GlyphHidden is not null;
  public bool ShouldSerializeGridBefore() => GridBefore is not null;
  public bool ShouldSerializeGridAfter() => GridAfter is not null;
  public bool ShouldSerializeWidthBefore() => WidthBefore is not null;
  public bool ShouldSerializeWidthAfter() => WidthAfter is not null;
  public bool ShouldSerializeDivId() => DivId is not null;
  public bool ShouldSerializeConditionalFormatStyle() => ConditionalFormatStyle is not null;
}
