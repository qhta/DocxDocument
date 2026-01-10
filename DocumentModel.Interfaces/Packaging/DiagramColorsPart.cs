using DocumentModel.Drawings.Diagrams;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DiagramColorsPart
/// </summary>
public interface DiagramColorsPart: OpenXmlPart
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ColorsDefinition? ColorsDefinition { get; set; }
}