namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BaseTableProperties<T> 
{
  public bool ShouldSerializeTableJustification() => TableJustification is not null && ShouldSerialize(TableJustification);
  public bool ShouldSerializeTableIndentation() => TableIndentation is not null && ShouldSerialize(TableIndentation);
  public bool ShouldSerializeDefaultTableCellMargin() => DefaultTableCellMargin is not null && ShouldSerialize(DefaultTableCellMargin);
  public bool ShouldSerializeTableCellSpacing() => TableCellSpacing is not null && ShouldSerialize(TableCellSpacing);
  public bool ShouldSerializeTableBorders() => TableBorders is not null && ShouldSerialize(TableBorders);
  public bool ShouldSerializeShading() => Shading is not null && ShouldSerialize(Shading);
}
