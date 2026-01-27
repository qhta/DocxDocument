namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class SupplementalFont
{
  public bool ShouldSerializeScript() => Script is not null;
  public bool ShouldSerializeTypeface() => Typeface is not null;
}
