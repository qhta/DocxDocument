namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of 3D pie chart extensions.
/// </summary>
[DataContract]
[XmlRoot("Pie3DChartExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class Pie3DChartExtensionList : ModelElementCollection<Pie3DChartExtension>
{
}