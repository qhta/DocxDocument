namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Area3DChartExtension Class.
/// </summary>
public class Area3DChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredAreaSeries? FilteredAreaSeries { get; set; }
}