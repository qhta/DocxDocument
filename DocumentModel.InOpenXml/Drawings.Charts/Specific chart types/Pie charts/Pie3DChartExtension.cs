namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a 3D pie chart, providing additional series filtering capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.Pie3DChartExtension))]
[DataContract]
[XmlRoot("Pie3DChartExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Pie3DChartExtension : Extension<DXDC.Pie3DChartExtension>
{
  /// <summary>
  ///   Filtered pie series for the chart extension.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FilteredPieSeries))]
  public FilteredPieSeries? FilteredPieSeries { get => _FilteredPieSeries; set => UpdateField(ref _FilteredPieSeries, value, nameof(FilteredPieSeries)); }
  private FilteredPieSeries? _FilteredPieSeries;
}