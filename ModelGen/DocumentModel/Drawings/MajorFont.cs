namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of major fonts which are to be used under different languages or locals.
/// </summary>
public partial class MajorFont
{
  public DocumentModel.Drawings.LatinFont? LatinFont { get; set; }
  
  public DocumentModel.Drawings.EastAsianFont? EastAsianFont { get; set; }
  
  public DocumentModel.Drawings.ComplexScriptFont? ComplexScriptFont { get; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
