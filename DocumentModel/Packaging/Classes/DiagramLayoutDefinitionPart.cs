namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramLayoutDefinitionPart
/// </summary>
public partial class DiagramLayoutDefinitionPart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.LayoutDefinition? LayoutDefinition { get; set; }
  
  public String? RelationshipType { get; }
  
}
