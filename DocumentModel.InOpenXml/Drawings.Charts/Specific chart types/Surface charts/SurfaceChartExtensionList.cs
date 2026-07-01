namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of surface chart extensions.
/// </summary>
[DataContract]
[XmlRoot("SurfaceChartExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class SurfaceChartExtensionList : ModelElementCollection<SurfaceChartExtension>
{
}