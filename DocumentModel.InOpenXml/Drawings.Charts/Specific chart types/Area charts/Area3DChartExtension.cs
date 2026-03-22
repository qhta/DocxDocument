namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for 3D Area Charts, providing additional series filtering capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.Area3DChartExtension))]
public partial class Area3DChartExtension : Extension<DXDC.Area3DChartExtension>
{
  /// <summary>
  ///   Specifies the filtered area series for the chart extension.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FilteredAreaSeries))]
  public FilteredAreaSeries? FilteredAreaSeries { get => _FilteredAreaSeries; set => UpdateField(ref _FilteredAreaSeries, value, nameof(FilteredAreaSeries)); }
  private FilteredAreaSeries? _FilteredAreaSeries;
}