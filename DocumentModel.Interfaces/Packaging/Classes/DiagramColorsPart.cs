using DocumentModel.Drawings.Diagrams;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DiagramColorsPart
/// </summary>
public class DiagramColorsPart: ModelElement
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ColorsDefinition? ColorsDefinition { get; set; }
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}