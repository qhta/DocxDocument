namespace DocumentModel.Drawings;

/// <summary>
/// Minor fonts.
/// </summary>
public partial class MinorFont
{
  public DocumentModel.Drawings.TextFontType? LatinFont { get; set; }
  
  public DocumentModel.Drawings.TextFontType? EastAsianFont { get; set; }
  
  public DocumentModel.Drawings.TextFontType? ComplexScriptFont { get; set; }
  
  public Collection<DocumentModel.Drawings.SupplementalFont>? SupplementalFonts { get; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
