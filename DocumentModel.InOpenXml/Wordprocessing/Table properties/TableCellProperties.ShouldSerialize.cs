namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class TableCellProperties
{
  public bool ShouldSerializeTableCellPropertiesChange() => TableCellPropertiesChange is not null;
}
