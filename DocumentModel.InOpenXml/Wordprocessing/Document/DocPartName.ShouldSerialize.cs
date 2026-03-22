namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class DocPartName
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeDecorated() => Decorated is not null;
}
