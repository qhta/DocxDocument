namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FontCollectionType Class.
/// </summary>
public interface IFontCollectionType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Latin Font.
  /// </summary>
  public ILatinFont? LatinFont { get ; set; }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public IEastAsianFont? EastAsianFont { get ; set; }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public IComplexScriptFont? ComplexScriptFont { get ; set; }
  
}
