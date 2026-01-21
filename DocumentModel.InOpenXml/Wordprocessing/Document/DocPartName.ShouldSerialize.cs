namespace DocumentModel.Wordprocessing;

public partial class DocPartName
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeDecorated() => Decorated is not null;
}
