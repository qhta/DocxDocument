namespace DocumentModel.Drawings.Charts;
/// <summary>
/// Defines the SeriesLine Class.
/// Each series line connects the data point in one series to the corresponding data point in another series.
/// Series lines are used in stacked charts and 100% stacked charts to show the relationship between the data points in different series.
/// They are not used in other types of charts, such as line charts or pie charts.
/// </summary>
[OpenXmlType(typeof(DXDC.SeriesLines))]
[DataContract]
[XmlRoot("SeriesLines", Namespace = "DocumentModel.Drawings.Charts")]
public class SeriesLines : ChartLinesType<DXDC.SeriesLines>
{
}