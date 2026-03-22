namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class CurrentTableCellProperties<T> 
{
  public bool ShouldSerializeConditionalFormatStyle() => ConditionalFormatStyle is not null;
  public bool ShouldSerializeTableCellWidth() => TableCellWidth is not null;
  public bool ShouldSerializeGridSpan() => GridSpan is not null;
  public bool ShouldSerializeHorizontalMerge() => HorizontalMerge is not null;
  public bool ShouldSerializeVerticalMerge() => VerticalMerge is not null;
  public bool ShouldSerializeTableCellBorders() => TableCellBorders is not null;
  public bool ShouldSerializeTextDirection() => TextDirection is not null;
  public bool ShouldSerializeTableCellFitText() => TableCellFitText is not null;
  public bool ShouldSerializeHideMark() => HideMark is not null;
  public bool ShouldSerializeCellInsertion() => CellInsertion is not null;
  public bool ShouldSerializeCellDeletion() => CellDeletion is not null;
  public bool ShouldSerializeCellMerge() => CellMerge is not null;
}
