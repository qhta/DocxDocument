namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of major fonts which are to be used under different languages or locals.
/// </summary>
public partial class MajorFont
{
  public DMD.LatinFont? LatinFont { get; set; }
  
  public DMD.EastAsianFont? EastAsianFont { get; set; }
  
  public DMD.ComplexScriptFont? ComplexScriptFont { get; set; }
  
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
