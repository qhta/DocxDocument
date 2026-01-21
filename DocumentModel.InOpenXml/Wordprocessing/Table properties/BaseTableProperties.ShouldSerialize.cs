namespace DocumentModel.Wordprocessing;

public partial class BaseTableProperties
{
  public bool ShouldSerializeTableJustification() => TableJustification is not null;
  public bool ShouldSerializeTableIndentation() => TableIndentation is not null;
  public bool ShouldSerializeDefaultTableCellMargin() => DefaultTableCellMargin is not null;
  public bool ShouldSerializeTableCellSpacing() => TableCellSpacing is not null;
  public bool ShouldSerializeTableBorders() => TableBorders is not null;
  public bool ShouldSerializeShading() => Shading is not null;
}
