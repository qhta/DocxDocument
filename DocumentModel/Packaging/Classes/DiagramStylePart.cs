using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DiagramStylePart
/// </summary>
public class DiagramStylePart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public StyleDefinition? StyleDefinition { get; set; }
}