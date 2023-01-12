namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramStylePart
/// </summary>
public partial class DiagramStylePart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.StyleDefinition? StyleDefinition { get; set; }
  
}
