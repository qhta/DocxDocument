namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FontCollectionType Class.
/// </summary>
public partial class FontCollectionType
{
  /// <summary>
  /// Latin Font.
  /// </summary>
  public DocumentModel.Drawings.TextFontType? LatinFont { get; set; }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public DocumentModel.Drawings.TextFontType? EastAsianFont { get; set; }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public DocumentModel.Drawings.TextFontType? ComplexScriptFont { get; set; }
  
}
