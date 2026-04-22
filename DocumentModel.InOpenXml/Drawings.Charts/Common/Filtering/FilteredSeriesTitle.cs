namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a filtered series title for a chart, including the chart text.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredSeriesTitle))]
[XmlRoot("FilteredSeriesTitle", Namespace = "DocumentModel.Drawings.Charts")]
public partial class FilteredSeriesTitle : ModelElement<DXO13DC.FilteredSeriesTitle>
{
 /// <summary>
 ///   Chart text associated with the filtered series title.
 /// </summary>
 [OpenXmlType(typeof(DXO13DC.ChartText))]
 public ChartText? ChartText { get => _ChartText; set => UpdateField(ref _ChartText, value, nameof(ChartText)); }
 private ChartText? _ChartText;
}