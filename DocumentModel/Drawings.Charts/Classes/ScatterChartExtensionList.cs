namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartExtensionList Class.
/// </summary>
public record ScatterChartExtensionList
{
  public Collection<ScatterChartExtension>? ScatterChartExtensions { get; set; }
}