namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of major fonts which are to be used under different languages or locals.
/// </summary>
public partial class MajorFont
{
  public DocumentModel.Drawings.TextFontType? LatinFont { get; set; }
  
  public DocumentModel.Drawings.TextFontType? EastAsianFont { get; set; }
  
  public DocumentModel.Drawings.TextFontType? ComplexScriptFont { get; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Drawings.SupplementalFont>? Items { get; set; }
  
}
