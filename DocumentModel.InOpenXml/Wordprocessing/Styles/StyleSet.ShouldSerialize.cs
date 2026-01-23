namespace DocumentModel.Wordprocessing;

public partial class StyleSet
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
