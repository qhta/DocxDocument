using DocumentModel.Drawings.Charts;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ChartPart
/// </summary>
public record ChartPart
{
  /// <summary>
  ///   Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  public Collection<ChartColorStylePart>? ChartColorStyleParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ChartSpace? ChartSpace { get; set; }

  /// <summary>
  ///   Gets the ChartStyleParts of the ChartPart
  /// </summary>
  public Collection<ChartStylePart>? ChartStyleParts { get; set; }

  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the ChartPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public String? RelationshipType { get; set; }
}