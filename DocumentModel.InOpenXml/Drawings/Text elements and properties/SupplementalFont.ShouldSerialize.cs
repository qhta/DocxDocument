namespace DocumentModel.Drawings;

public partial class SupplementalFont
{
  public bool ShouldSerializeScript() => Script is not null;
  public bool ShouldSerializeTypeface() => Typeface is not null;
}
