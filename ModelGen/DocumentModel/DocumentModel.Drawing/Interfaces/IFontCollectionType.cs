namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FontCollectionType Class.
/// </summary>
public interface IFontCollectionType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Latin Font.
  /// </summary>
  public DocumentModel.Drawing.ITextFontType? LatinFont { get ; set; }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public DocumentModel.Drawing.ITextFontType? EastAsianFont { get ; set; }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public DocumentModel.Drawing.ITextFontType? ComplexScriptFont { get ; set; }
  
}
