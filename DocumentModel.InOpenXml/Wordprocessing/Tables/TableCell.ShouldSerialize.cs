namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableCell
{
  public bool ShouldSerializeTableCellProperties() => TableCellProperties is not null && ShouldSerialize(TableCellProperties);
}
