namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomizationPart
/// </summary>
public class CustomizationPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomizationPart
{
  public new DocumentFormat.OpenXml.Packaging.CustomizationPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CustomizationPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomizationPartImpl(): base() {}
  
  public CustomizationPartImpl(DocumentFormat.OpenXml.Packaging.CustomizationPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.CustomizationPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.CustomizationPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.TemplateCommandGroup? TemplateCommandGroup
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
