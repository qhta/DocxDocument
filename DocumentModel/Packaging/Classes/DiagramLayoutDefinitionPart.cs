using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DiagramLayoutDefinitionPart
/// </summary>
public record DiagramLayoutDefinitionPart
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public LayoutDefinition? LayoutDefinition { get; set; }

  public String? RelationshipType { get; set; }
}