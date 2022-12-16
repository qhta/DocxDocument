namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemeOverridePart
/// </summary>
public class ThemeOverridePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ThemeOverridePart
{
  public new DocumentFormat.OpenXml.Packaging.ThemeOverridePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ThemeOverridePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ThemeOverridePartImpl(): base() {}
  
  public ThemeOverridePartImpl(DocumentFormat.OpenXml.Packaging.ThemeOverridePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ThemeOverridePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemeOverridePart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ThemeOverridePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ThemeOverride? ThemeOverride
  {
    get
    {
      if (OpenXmlElement?.ThemeOverride != null)
        return new DocumentModel.Drawings.ThemeOverrideImpl(OpenXmlElement.ThemeOverride);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.ThemeOverrideImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.ThemeOverride = valueImpl.OpenXmlElement;
    }
  }
  
}
