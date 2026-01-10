using DocumentModel.Drawings.Diagrams;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DiagramStylePart
/// </summary>
public interface DiagramStylePart: OpenXmlPart
{


  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public StyleDefinition? StyleDefinition { get; set; }
}