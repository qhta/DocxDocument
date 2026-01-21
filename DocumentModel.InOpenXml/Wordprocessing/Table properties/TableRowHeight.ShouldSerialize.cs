namespace DocumentModel.Wordprocessing;

public partial class TableRowHeight
{
  public bool ShouldSerializeType() => Type is not null;
}
