namespace DocumentModel.Wordprocessing;

public partial class StatusText
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
