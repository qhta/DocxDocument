namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
/// Collection of Series elements within a chart,
/// representing the individual data series that are plotted on the chart.
/// Each Series element contains properties and data points that define how the series
/// is displayed and behaves within the chart, such as its layout, visibility, formatting, and associated text.
/// The SeriesList class provides a structured way to manage multiple series within a chart,
/// allowing for easy access and manipulation of each series' properties and data.
/// </summary>
[XmlRoot("SeriesList", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class SeriesList : ModelElementCollection<Series>
{
}