namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a pie chart, providing additional series filtering capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.PieChartExtension))]
public partial class PieChartExtension : Extension<DXDC.PieChartExtension>
{
  /// <summary>
  ///   Filtered pie series for the chart extension.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FilteredPieSeries))]
  public FilteredPieSeries? FilteredPieSeries { get => _FilteredPieSeries; set => UpdateField(ref _FilteredPieSeries, value, nameof(FilteredPieSeries)); }

  private FilteredPieSeries? _FilteredPieSeries;
}