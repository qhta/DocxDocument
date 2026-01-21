namespace DocumentModel.Drawings;

public partial class SchemeColor
{
  public bool ShouldSerializeVal() => Val is not null;
}
