namespace DocumentModel.Drawings.Pictures;
/// <summary>
///  Specific DXDP.NonVisualDrawingProperties mapping type.
/// </summary>
[OpenXmlType(typeof(DXDP.NonVisualDrawingProperties))]
[DataContract]
[XmlRoot("NonVisualDrawingProperties", Namespace = "DocumentModel.Drawings.Pictures")]
public partial class NonVisualDrawingProperties : DMD.NonVisualDrawingProperties<DXDP.NonVisualDrawingProperties>
{
}