namespace DocumentModel.Wordprocessing;

public partial class Table
{
  public bool ShouldSerializeTableProperties() => TableProperties is not null;
  public bool ShouldSerializeTableGrid() => TableGrid is not null;
}
