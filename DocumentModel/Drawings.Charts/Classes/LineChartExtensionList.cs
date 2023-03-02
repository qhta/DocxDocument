namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LineChartExtensionList Class.
/// </summary>
public record LineChartExtensionList
{
  public Collection<LineChartExtension>? LineChartExtensions { get; set; }
}