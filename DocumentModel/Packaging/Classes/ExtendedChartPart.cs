using DocumentModel.Drawings.ChartDrawings;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ExtendedChartPart
/// </summary>
public class ExtendedChartPart: ModelElement
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

  public string? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public string? RelationshipType { get; set; }
}