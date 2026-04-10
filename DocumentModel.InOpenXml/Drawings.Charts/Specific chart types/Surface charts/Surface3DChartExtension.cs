namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a 3D surface chart, providing additional series filtering capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.Surface3DChartExtension))]
[XmlRoot("Surface3DChartExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Surface3DChartExtension : Extension<DXDC.Surface3DChartExtension>
{
 /// <summary>
 ///   Filtered surface series for the chart extension.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.FilteredSurfaceSeries))]
 public FilteredSurfaceSeries? FilteredSurfaceSeries { get => _FilteredSurfaceSeries; set => UpdateField(ref _FilteredSurfaceSeries, value, nameof(FilteredSurfaceSeries)); }

 private FilteredSurfaceSeries? _FilteredSurfaceSeries;
}