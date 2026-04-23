namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BaseTableRowProperties<T> 
{
  public bool ShouldSerializeRowHeight() => RowHeight is not null && ShouldSerialize(RowHeight);
  public bool ShouldSerializeCantSplit() => CantSplit is not null;
  public bool ShouldSerializeIsHeader() => IsHeader is not null;
  public bool ShouldSerializeRowAlignment() => RowAlignment is not null && ShouldSerialize(RowAlignment);
  public bool ShouldSerializeCellSpacing() => CellSpacing is not null && ShouldSerialize(CellSpacing);
  public bool ShouldSerializeGlyphHidden() => GlyphHidden is not null;
  public bool ShouldSerializeGridBefore() => GridBefore is not null && ShouldSerialize(GridBefore);
  public bool ShouldSerializeGridAfter() => GridAfter is not null && ShouldSerialize(GridAfter);
  public bool ShouldSerializeWidthBefore() => WidthBefore is not null && ShouldSerialize(WidthBefore);
  public bool ShouldSerializeWidthAfter() => WidthAfter is not null && ShouldSerialize(WidthAfter);
  public bool ShouldSerializeDivId() => !String.IsNullOrEmpty(DivId);
  public bool ShouldSerializeConditionalFormatStyle() => ConditionalFormatStyle is not null && ShouldSerialize(ConditionalFormatStyle);
}
