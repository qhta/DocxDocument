namespace DocumentModel;
#pragma warning disable CS1591
public partial class SchemeColor
{
  public bool ShouldSerializeVal() => Val is not null;
}
