namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of 3D line chart extensions.
/// </summary>
[DataContract]
[XmlRoot("Line3DChartExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class Line3DChartExtensionList : ModelElementCollection<Line3DChartExtension>
{
}