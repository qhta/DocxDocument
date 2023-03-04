using DocumentModel.Drawings.Charts;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ChartDrawingPart
/// </summary>
public class ChartDrawingPart
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public UserShapes? UserShapes { get; set; }
}