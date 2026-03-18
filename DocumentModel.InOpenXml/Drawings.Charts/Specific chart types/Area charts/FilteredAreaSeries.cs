using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredAreaSeries Class.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredAreaSeries))]
public class FilteredAreaSeries: ModelElement<DXO13DC.FilteredAreaSeries>
{
  /// <summary>
  ///   AreaChartSeries.
  /// </summary>
  public AreaChartSeries3? AreaChartSeries { get; set; }
}