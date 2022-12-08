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
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public ImagePart? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.LayoutDefinition? LayoutDefinition
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
