namespace DocumentModel.Drawings;

/// <summary>
///   Minor fonts.
/// </summary>
public class MinorFont: ModelElement
{
  public TextFontType? LatinFont { get; set; }

  public TextFontType? EastAsianFont { get; set; }

  public TextFontType? ComplexScriptFont { get; set; }

  public Collection<SupplementalFont>? SupplementalFonts { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}