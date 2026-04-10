namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a filtered bubble series for a chart, containing a reference to a bubble chart series.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredBubbleSeries))]
[XmlRoot("FilteredBubbleSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class FilteredBubbleSeries : ModelElement<DXO13DC.FilteredBubbleSeries>
{
 /// <summary>
 ///   Bubble chart series associated with the filtered bubble series.
 /// </summary>
 [OpenXmlType(typeof(DXO13DC.BubbleChartSeries))]
 public BubbleChartSeries? BubbleChartSeries { get => _BubbleChartSeries; set => UpdateField(ref _BubbleChartSeries, value, nameof(BubbleChartSeries)); }

 private BubbleChartSeries? _BubbleChartSeries;
}