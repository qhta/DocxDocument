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
  
  public FontCollectionTypeImpl(): base() {}
  
  public FontCollectionTypeImpl(DocumentFormat.OpenXml.Drawing.FontCollectionType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Latin Font.
  /// </summary>
  public virtual DocumentModel.Drawings.TextFontType? LatinFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public virtual DocumentModel.Drawings.TextFontType? EastAsianFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public virtual DocumentModel.Drawings.TextFontType? ComplexScriptFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
