namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of bar chart extensions.
/// </summary>
[DataContract]
[XmlRoot("BarChartExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class BarChartExtensionList : ModelElementCollection<BarChartExtension>
{
}