namespace DocumentModel.Wordprocessing;

public partial class TableCellProperties
{
  public bool ShouldSerializeTableCellPropertiesChange() => TableCellPropertiesChange is not null;
}
