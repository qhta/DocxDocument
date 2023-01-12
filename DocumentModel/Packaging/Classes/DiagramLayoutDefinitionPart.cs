namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramLayoutDefinitionPart
/// </summary>
public partial class DiagramLayoutDefinitionPart
{
  public String? ContentType { get; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.LayoutDefinition? LayoutDefinition { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
