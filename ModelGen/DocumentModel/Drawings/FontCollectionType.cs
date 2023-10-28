namespace DocumentModel.Drawings;


/// <summary>
///   Defines the FontCollectionType Class.
/// </summary>
public partial class FontCollectionType
{
  
  /// <summary>
  ///   Latin Font.
  /// </summary>
  public DMD.LatinFont? LatinFont { get; set; }
  
  
  /// <summary>
  ///   East Asian Font.
  /// </summary>
  public DMD.EastAsianFont? EastAsianFont { get; set; }
  
  
  /// <summary>
  ///   Complex Script Font.
  /// </summary>
  public DMD.ComplexScriptFont? ComplexScriptFont { get; set; }
  
}
