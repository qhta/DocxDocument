namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BarChartExtensionList Class.
/// </summary>
public record BarChartExtensionList
{
  public Collection<BarChartExtension>? BarChartExtensions { get; set; }
}