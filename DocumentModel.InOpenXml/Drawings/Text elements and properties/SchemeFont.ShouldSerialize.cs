namespace DocumentModel.Drawings;

public partial class SchemeFont<T> 
{
  public bool ShouldSerializeLatinFont() => LatinFont is not null;
  public bool ShouldSerializeEastAsianFont() => EastAsianFont is not null;
  public bool ShouldSerializeComplexScriptFont() => ComplexScriptFont is not null;
  public bool ShouldSerializeSupplementalFonts() => SupplementalFonts is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
