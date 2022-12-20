namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomizationPart
/// </summary>
public partial class CustomizationPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomizationPart
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
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.TemplateCommandGroup? TemplateCommandGroup
  {
    get
    {
      if (OpenXmlElement?.TemplateCommandGroup != null)
        return new DocumentModel.Wordprocessing.TemplateCommandGroupImpl(OpenXmlElement.TemplateCommandGroup);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.TemplateCommandGroupImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.TemplateCommandGroup = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the WordAttachedToolbarsPart of the CustomizationPart
  /// </summary>
  public DocumentModel.Packaging.WordAttachedToolbarsPart? WordAttachedToolbarsPart
  {
    get
    {
      if (OpenXmlElement?.WordAttachedToolbarsPart != null)
        return new DocumentModel.Packaging.WordAttachedToolbarsPartImpl(OpenXmlElement.WordAttachedToolbarsPart);
      return null;
    }
  }
  
}
