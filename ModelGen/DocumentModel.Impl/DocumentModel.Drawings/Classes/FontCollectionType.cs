namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FontCollectionType Class.
/// </summary>
public class FontCollectionTypeImpl: ModelElementImpl, FontCollectionType
{
  public DocumentFormat.OpenXml.Drawing.FontCollectionType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FontCollectionType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Latin Font.
  /// </summary>
  public virtual TextFontType? LatinFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public virtual TextFontType? EastAsianFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public virtual TextFontType? ComplexScriptFont
  {
    get;
    set;
  }
  
}
