namespace DocumentModel.Wordprocessing;

public partial class TableGrid
{
  public bool ShouldSerializeTableGridChange() => TableGridChange is not null;
}
