namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the AreaChartExtension Class.
/// </summary>
public record AreaChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredAreaSeries? FilteredAreaSeries { get; set; }
}