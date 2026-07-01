namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of bubble chart extensions.
/// </summary>
[DataContract]
[XmlRoot("BubbleChartExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class BubbleChartExtensionList : ModelElementCollection<BubbleChartExtension>
{
}