namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of 3D surface chart extension items.
/// </summary>
[DataContract]
[XmlRoot("Surface3DChartExtensions", Namespace = "DocumentModel.Drawings.Charts")]
public class Surface3DChartExtensions : ModelElementCollection<Surface3DChartExtension>
{
}