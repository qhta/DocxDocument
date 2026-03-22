namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class AlphaReplace
{
  public bool ShouldSerializeAlpha() => Alpha is not null;
}
