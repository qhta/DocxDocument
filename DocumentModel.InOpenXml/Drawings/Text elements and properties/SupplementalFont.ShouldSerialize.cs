namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class SupplementalFont
{
  public bool ShouldSerializeScript() => !String.IsNullOrEmpty(Script);
  public bool ShouldSerializeTypeface() => !String.IsNullOrEmpty(Typeface);
}
