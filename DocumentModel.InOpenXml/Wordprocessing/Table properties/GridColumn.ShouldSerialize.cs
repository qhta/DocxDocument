namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class GridColumn
{
  public bool ShouldSerializeWidth() => Width is not null;
}
