namespace DocumentModel;

public partial class SchemeColor
{
  public bool ShouldSerializeVal() => Val is not null;
}
