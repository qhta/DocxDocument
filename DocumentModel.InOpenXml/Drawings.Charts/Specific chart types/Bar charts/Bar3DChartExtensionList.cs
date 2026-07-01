namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of 3D bar chart extensions.
/// </summary>
[DataContract]
[XmlRoot("Bar3DChartExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class Bar3DChartExtensionList : ModelElementCollection<Bar3DChartExtension>
{
}