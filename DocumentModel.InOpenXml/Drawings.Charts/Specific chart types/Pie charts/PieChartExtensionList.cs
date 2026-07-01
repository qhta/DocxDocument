namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of pie chart extensions.
/// </summary>
[DataContract]
[XmlRoot("PieChartExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class PieChartExtensionList : ModelElementCollection<PieChartExtension>
{
}