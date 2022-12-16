namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontTablePart
/// </summary>
public class FontTablePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, FontTablePart
{
  public new DocumentFormat.OpenXml.Packaging.FontTablePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.FontTablePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FontTablePartImpl(): base() {}
  
  public FontTablePartImpl(DocumentFormat.OpenXml.Packaging.FontTablePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.FontTablePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the FontParts of the FontTablePart
  /// </summary>
  public DocumentModel.Packaging.FontPart? FontParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Fonts? Fonts
  {
    get
    {
      if (OpenXmlElement?.Fonts != null)
        return new DocumentModel.Wordprocessing.FontsImpl(OpenXmlElement.Fonts);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.FontsImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Fonts = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.FontTablePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
