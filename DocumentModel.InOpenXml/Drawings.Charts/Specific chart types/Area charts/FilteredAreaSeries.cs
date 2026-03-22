using DocumentFormat.OpenXml.EMMA;
namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Defines the FilteredAreaSeries Class.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredAreaSeries))]
public partial class FilteredAreaSeries : ModelElement<DXO13DC.FilteredAreaSeries>
{
  /// <summary>
  ///   AreaChartSeries.
  /// </summary>
  [OpenXmlType(typeof(DXO13DC.AreaChartSeries))]
  public AreaChartSeries? AreaChartSeries { get => _AreaChartSeries; set => UpdateField(ref _AreaChartSeries, value, nameof(AreaChartSeries)); }
  private AreaChartSeries? _AreaChartSeries;
}