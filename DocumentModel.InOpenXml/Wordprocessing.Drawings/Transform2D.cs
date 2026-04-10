using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specific DXO10WD.Transform2D mapping type.
/// </summary>
[OpenXmlType(typeof(DXO10W.Transform2D))]
[XmlRoot("Transform2D", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class Transform2D : DMD.Transform2D<DXO10W.Transform2D>
{
}