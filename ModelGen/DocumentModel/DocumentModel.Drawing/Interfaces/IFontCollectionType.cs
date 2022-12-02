namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FontCollectionType Class.
/// </summary>
public interface IFontCollectionType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Latin Font.
  /// </summary>
  public ITextFontType? LatinFont { get ; set; }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public ITextFontType? EastAsianFont { get ; set; }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public ITextFontType? ComplexScriptFont { get ; set; }
  
}
