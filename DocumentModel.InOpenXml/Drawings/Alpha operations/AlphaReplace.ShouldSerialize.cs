namespace DocumentModel.Drawings;

public partial class AlphaReplace
{
  public bool ShouldSerializeAlpha() => Alpha is not null;
}
