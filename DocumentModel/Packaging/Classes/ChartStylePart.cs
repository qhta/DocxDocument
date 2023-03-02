using DocumentModel.Drawings.ChartsStyle;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ChartStylePart
/// </summary>
public record ChartStylePart
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ChartStyle? ChartStyle { get; set; }

  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}