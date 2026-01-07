using DocumentModel.Drawings.ChartDrawings;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ExtendedChartPart
/// </summary>
public interface ExtendedChartPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  public ChartColorStyleParts ChartColorStyleParts { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ChartSpace? ChartSpace { get; set; }
  /// <summary>
  ///   Gets the ChartStyleParts of the ExtendedChartPart
  /// </summary>
  public ChartStyleParts ChartStyleParts { get; set; }
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  public string? RelationshipType { get; set; }
}