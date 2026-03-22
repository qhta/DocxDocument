namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a surface chart, providing additional series filtering capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.SurfaceChartExtension))]
public partial class SurfaceChartExtension: Extension<DXDC.SurfaceChartExtension>
{
  /// <summary>
  ///   Filtered surface series for the chart extension.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FilteredSurfaceSeries))]
  public FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get => _FilteredSurfaceSeries;
    set => UpdateField(ref _FilteredSurfaceSeries, value, nameof(FilteredSurfaceSeries));
  }
  private FilteredSurfaceSeries? _FilteredSurfaceSeries;
}