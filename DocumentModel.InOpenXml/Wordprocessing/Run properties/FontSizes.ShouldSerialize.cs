namespace DocumentModel;

public partial class FontSizes
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeValCS() => ValCS is not null;
}
