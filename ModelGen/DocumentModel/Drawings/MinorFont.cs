namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of minor fonts that are to be used under different languages or locals.
/// </summary>
public partial class MinorFont
{
  public DMD.LatinFont? LatinFont { get; set; }
  
  public DMD.EastAsianFont? EastAsianFont { get; set; }
  
  public DMD.ComplexScriptFont? ComplexScriptFont { get; set; }
  
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
