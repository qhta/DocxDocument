namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class StatusText
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
