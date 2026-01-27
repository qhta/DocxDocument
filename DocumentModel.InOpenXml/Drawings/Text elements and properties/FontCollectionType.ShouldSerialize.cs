namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class FontCollectionType
{
  public bool ShouldSerializeLatinFont() => LatinFont is not null;
  public bool ShouldSerializeEastAsianFont() => EastAsianFont is not null;
  public bool ShouldSerializeComplexScriptFont() => ComplexScriptFont is not null;
}
