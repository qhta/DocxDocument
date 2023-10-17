namespace DocumentModel.Drawings;


/// <summary>
///   Defines the FontCollectionType Class.
/// </summary>
public partial class FontCollectionType
{
  
  /// <summary>
  ///   Latin Font.
  /// </summary>
  public DocumentModel.Drawings.LatinFont? LatinFont { get; set; }
  
  
  /// <summary>
  ///   East Asian Font.
  /// </summary>
  public DocumentModel.Drawings.EastAsianFont? EastAsianFont { get; set; }
  
  
  /// <summary>
  ///   Complex Script Font.
  /// </summary>
  public DocumentModel.Drawings.ComplexScriptFont? ComplexScriptFont { get; set; }
  
}
