using DocumentModel.Drawings.Diagrams;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DiagramStylePart
/// </summary>
public class DiagramStylePart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public StyleDefinition? StyleDefinition { get; set; }
}