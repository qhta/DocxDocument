namespace DocumentModel.Drawings.Office;
/// <summary>
/// Specific DXOD.Transform2D mapping type.
/// </summary>
[OpenXmlType(typeof(DXOD.Transform2D))]
[DataContract]
[XmlRoot("Transform2D", Namespace = "DocumentModel.Drawings.Office")]
public partial class Transform2D : DMD.Transform2D<DXOD.Transform2D>
{
}