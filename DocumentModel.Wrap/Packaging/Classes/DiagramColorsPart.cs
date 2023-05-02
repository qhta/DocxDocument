using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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