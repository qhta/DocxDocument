using DocumentModel.Drawings.Diagrams;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DiagramLayoutDefinitionPart
/// </summary>
public interface DiagramLayoutDefinitionPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public LayoutDefinition? LayoutDefinition { get; set; }
}