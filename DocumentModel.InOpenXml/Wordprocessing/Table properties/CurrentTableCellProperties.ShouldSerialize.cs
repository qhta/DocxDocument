namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CurrentTableCellProperties<T> 
{
  public bool ShouldSerializeConditionalFormatStyle() => ConditionalFormatStyle is not null && ShouldSerialize(ConditionalFormatStyle);
  public bool ShouldSerializeTableCellWidth() => TableCellWidth is not null && ShouldSerialize(TableCellWidth);
  public bool ShouldSerializeGridSpan() => GridSpan is not null && ShouldSerialize(GridSpan);
  public bool ShouldSerializeHorizontalMerge() => HorizontalMerge is not null && ShouldSerialize(HorizontalMerge);
  public bool ShouldSerializeVerticalMerge() => VerticalMerge is not null && ShouldSerialize(VerticalMerge);
  public bool ShouldSerializeTableCellBorders() => TableCellBorders is not null && ShouldSerialize(TableCellBorders);
  public bool ShouldSerializeTextDirection() => TextDirection is not null && ShouldSerialize(TextDirection);
  public bool ShouldSerializeTableCellFitText() => TableCellFitText is not null;
  public bool ShouldSerializeHideMark() => HideMark is not null;
  public bool ShouldSerializeCellInsertion() => CellInsertion is not null && ShouldSerialize(CellInsertion);
  public bool ShouldSerializeCellDeletion() => CellDeletion is not null && ShouldSerialize(CellDeletion);
  public bool ShouldSerializeCellMerge() => CellMerge is not null && ShouldSerialize(CellMerge);
}
