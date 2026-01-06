namespace DocumentModel.Drawings;

/// <summary>
///   Major Font.
/// </summary>
public interface MajorFont: ExtendableElement
{
  public TextFontType? LatinFont { get; set; }
  public TextFontType? EastAsianFont { get; set; }
  public TextFontType? ComplexScriptFont { get; set; }
  public Collection<SupplementalFont>? SupplementalFonts { get; set; }
}