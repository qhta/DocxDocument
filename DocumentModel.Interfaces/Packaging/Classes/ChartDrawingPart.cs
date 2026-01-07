using DocumentModel.Drawings.Charts;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ChartDrawingPart
/// </summary>
public interface ChartDrawingPart: OpenXmlPart
{

  /// <summary>
  ///   Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  public ImageParts ImageParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public UserShapes? UserShapes { get; set; }
}