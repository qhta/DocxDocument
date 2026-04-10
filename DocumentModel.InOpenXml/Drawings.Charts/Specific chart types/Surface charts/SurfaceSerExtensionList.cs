namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of surface chart series extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.Surface3DChartExtensionList))]
[XmlRoot("SurfaceSerExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class SurfaceSerExtensionList : ModelElementCollection<SurfaceSerExtension, DXDC.Surface3DChartExtensionList, DXDC.Surface3DChartExtension>
{
}