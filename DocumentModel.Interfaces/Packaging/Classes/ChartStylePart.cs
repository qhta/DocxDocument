using DocumentModel.Drawings.ChartsStyle;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ChartStylePart
/// </summary>
public class ChartStylePart: ModelElement
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ChartStyle? ChartStyle { get; set; }
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}