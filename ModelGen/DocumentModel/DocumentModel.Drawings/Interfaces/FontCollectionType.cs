namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FontCollectionType Class.
/// </summary>
public interface FontCollectionType
{
  /// <summary>
  /// Latin Font.
  /// </summary>
  public TextFontType? LatinFont { get ; set; }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public TextFontType? EastAsianFont { get ; set; }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public TextFontType? ComplexScriptFont { get ; set; }
  
}
