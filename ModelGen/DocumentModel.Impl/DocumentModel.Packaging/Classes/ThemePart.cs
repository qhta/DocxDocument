namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemePart
/// </summary>
public class ThemePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ThemePart
{
  public new DocumentFormat.OpenXml.Packaging.ThemePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ThemePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ThemePartImpl(): base() {}
  
  public ThemePartImpl(DocumentFormat.OpenXml.Packaging.ThemePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ThemePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemePart
  /// </summary>
  public ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ThemePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Theme? Theme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
