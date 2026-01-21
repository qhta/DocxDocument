namespace DocumentModel.Drawings;

public partial class SystemColor
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeLastColor() => LastColor is not null;
}
