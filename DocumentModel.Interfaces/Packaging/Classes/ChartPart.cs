using DocumentModel.Drawings.Charts;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ChartPart
/// </summary>
public interface ChartPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  public ChartColorStyleParts ChartColorStyleParts { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ChartSpace? ChartSpace { get; set; }
  /// <summary>
  ///   Gets the ChartStyleParts of the ChartPart
  /// </summary>
  public ChartStyleParts ChartStyleParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the ChartPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
}