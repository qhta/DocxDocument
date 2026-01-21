namespace DocumentModel.Wordprocessing;

public partial class TableLayout
{
  public bool ShouldSerializeType() => Type is not null;
}
