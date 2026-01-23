namespace DocumentModel.Wordprocessing;

public partial class GridColumn
{
  public bool ShouldSerializeWidth() => Width is not null;
}
