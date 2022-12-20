namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramStylePart
/// </summary>
public partial interface DiagramStylePart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.StyleDefinition? StyleDefinition { get; set; }
  
}
