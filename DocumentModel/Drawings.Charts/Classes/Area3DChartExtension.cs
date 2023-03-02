namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Area3DChartExtension Class.
/// </summary>
public record Area3DChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredAreaSeries? FilteredAreaSeries { get; set; }
}