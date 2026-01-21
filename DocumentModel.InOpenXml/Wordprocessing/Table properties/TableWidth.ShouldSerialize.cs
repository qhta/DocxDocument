namespace DocumentModel.Wordprocessing;

public partial class TableWidth
{
  public bool ShouldSerializeType() => Type is not null;
}
