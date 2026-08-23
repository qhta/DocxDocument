namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Defines the FilteredSurfaceSeries Class.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredSurfaceSeries))]
[DataContract]
[XmlRoot("FilteredSurfaceSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class FilteredSurfaceSeries : ModelElement<DXDC.SurfaceChartSeries>
{
  /// <summary>
  ///   Surface chart series associated with the filtered surface series.
  /// </summary>
  [OpenXmlType(typeof(DXO13DC.SurfaceChartSeries))]
  public SurfaceChartSeries? SurfaceChartSeries { get => _SurfaceChartSeries; set => UpdateField(ref _SurfaceChartSeries, value, nameof(SurfaceChartSeries)); }
  private SurfaceChartSeries? _SurfaceChartSeries;
}