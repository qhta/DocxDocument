using DocumentModel.Drawings.ChartDrawings;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ExtendedChartPart
/// </summary>
public class ExtendedChartPart
{
  /// <summary>
  ///   Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  public Collection<ChartColorStylePart>? ChartColorStyleParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ChartSpace? ChartSpace { get; set; }

  /// <summary>
  ///   Gets the ChartStyleParts of the ExtendedChartPart
  /// </summary>
  public Collection<ChartStylePart>? ChartStyleParts { get; set; }

  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public String? RelationshipType { get; set; }
}