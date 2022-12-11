namespace DocumentModel.Drawings;

/// <summary>
/// Major Font.
/// </summary>
public interface MajorFont
{
  public TextFontType? LatinFont { get ; set; }
  
  public TextFontType? EastAsianFont { get ; set; }
  
  public TextFontType? ComplexScriptFont { get ; set; }
  
  public Collection<SupplementalFont>? SupplementalFonts { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
