namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of scatter chart extensions.
/// </summary>
[DataContract]
[XmlRoot("ScatterChartExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class ScatterChartExtensionList : ModelElementCollection<ScatterChartExtension>
{
}