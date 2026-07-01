namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a stock chart, providing additional series extension capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.StockChartExtension))]
[DataContract]
[XmlRoot("StockChartExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class StockChartExtension : Extension<DXDC.StockChartExtension>
{
 /// <summary>
 ///   Filtered line series extension for the stock chart extension.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.FilteredLineSeriesExtension))]
 public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get => _FilteredLineSeriesExtension; set => UpdateField(ref _FilteredLineSeriesExtension, value, nameof(FilteredLineSeriesExtension)); }
 private FilteredLineSeriesExtension? _FilteredLineSeriesExtension;
}