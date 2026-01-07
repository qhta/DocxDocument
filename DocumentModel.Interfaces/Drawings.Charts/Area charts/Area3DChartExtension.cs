namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Area3DChartExtension Class.
/// </summary>
public interface Area3DChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredAreaSeries? FilteredAreaSeries { get; set; }
}