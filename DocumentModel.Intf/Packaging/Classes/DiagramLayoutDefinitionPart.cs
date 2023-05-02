using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DiagramLayoutDefinitionPart
/// </summary>
public class DiagramLayoutDefinitionPart: ModelElement
{
  public string? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public LayoutDefinition? LayoutDefinition { get; set; }

  public string? RelationshipType { get; set; }
}