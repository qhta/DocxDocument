namespace DocumentModel.Drawings.Office;
/// <summary>
/// Specific DXD.NonVisualDrawingProperties mapping type
/// </summary>
[OpenXmlType(typeof(DXOD.NonVisualDrawingProperties))]
[DataContract]
[XmlRoot("NonVisualDrawingProperties", Namespace = "DocumentModel.Drawings.Office")]
public class NonVisualDrawingProperties : DMD.NonVisualDrawingProperties<DXOD.NonVisualDrawingProperties>
{
}