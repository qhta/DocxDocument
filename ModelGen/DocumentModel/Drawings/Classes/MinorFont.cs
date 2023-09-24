namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of minor fonts that are to be used under different languages or locals.
/// </summary>
public partial class MinorFont
{
  public TextFontType? LatinFont { get; set; }
  
  public TextFontType? EastAsianFont { get; set; }
  
  public TextFontType? ComplexScriptFont { get; set; }
  
  public ExtensionList? ExtensionList { get; set; }
  
  public ElementCollection<SupplementalFont>? Items { get; set; }
  
}
