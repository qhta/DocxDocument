namespace DocumentModel.Wordprocessing;

public partial class HelpText
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
