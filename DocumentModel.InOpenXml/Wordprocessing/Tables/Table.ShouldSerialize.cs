namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Table
{
  public bool ShouldSerializeTableProperties() => TableProperties is not null;
  public bool ShouldSerializeTableGrid() => TableGrid is not null;
}
