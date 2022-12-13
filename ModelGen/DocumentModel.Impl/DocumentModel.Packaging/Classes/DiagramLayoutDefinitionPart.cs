namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramLayoutDefinitionPart
/// </summary>
public class DiagramLayoutDefinitionPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramLayoutDefinitionPart
{
  public new DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramLayoutDefinitionPartImpl(): base() {}
  
  public DiagramLayoutDefinitionPartImpl(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.LayoutDefinition? LayoutDefinition
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
        typeof(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
