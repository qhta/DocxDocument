namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
public interface DiagramColorsPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ColorsDefinition? ColorsDefinition { get ; set; }
  
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
