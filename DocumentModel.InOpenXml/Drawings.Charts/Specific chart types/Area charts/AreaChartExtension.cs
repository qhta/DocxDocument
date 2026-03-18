namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for an area chart, providing additional series filtering capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.AreaChartExtension))]
public partial class AreaChartExtension : Extension<DXDC.AreaChartExtension>
{
  /// <summary>
  ///   Filtered area series for the chart extension.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FilteredAreaSeries))]
  public FilteredAreaSeries? FilteredAreaSeries { get => _FilteredAreaSeries; set => UpdateField(ref _FilteredAreaSeries, value, nameof(FilteredAreaSeries)); }

  private FilteredAreaSeries? _FilteredAreaSeries;
}