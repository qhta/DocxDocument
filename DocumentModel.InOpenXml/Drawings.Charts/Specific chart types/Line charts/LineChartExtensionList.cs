namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of line chart extensions.
/// </summary>
[DataContract]
[XmlRoot("LineChartExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class LineChartExtensionList : ModelElementCollection<LineChartExtension>
{
}