namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
/// Collection of unsigned integer values representing subtotals in a chart,
/// which may be used to define specific subtotal values for data series or categories within the chart,
/// contributing to the overall data representation and visualization of subtotals
/// in the chart's layout and formatting.
/// </summary>
[DataContract]
[XmlRoot("Subtotals", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class Subtotals : Collection<UInt32>
{
}