namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the RadarChartExtensionList Class.
/// </summary>
public record RadarChartExtensionList
{
  public Collection<RadarChartExtension>? RadarChartExtensions { get; set; }
}