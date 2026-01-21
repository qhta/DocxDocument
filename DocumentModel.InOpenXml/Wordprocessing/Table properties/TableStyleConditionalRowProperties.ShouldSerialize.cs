namespace DocumentModel.Wordprocessing;

public partial class TableStyleConditionalRowProperties
{
  public bool ShouldSerializeHidden() => Hidden is not null;
  public bool ShouldSerializeCantSplit() => CantSplit is not null;
  public bool ShouldSerializeTableHeader() => TableHeader is not null;
  public bool ShouldSerializeTableCellSpacing() => TableCellSpacing is not null;
  public bool ShouldSerializeTableJustification() => TableJustification is not null;
}
