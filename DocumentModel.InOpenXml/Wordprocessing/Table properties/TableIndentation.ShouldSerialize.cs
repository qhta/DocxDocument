namespace DocumentModel.Wordprocessing;

public partial class TableIndentation
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeType() => Type is not null;
}
