namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the AreaChartExtension Class.
/// </summary>
public class AreaChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredAreaSeries? FilteredAreaSeries { get; set; }
}