namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
public partial class DiagramColorsPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ColorsDefinition? ColorsDefinition { get; set; }
  
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
