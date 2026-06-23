namespace DocumentModel.Drawings;
/// <summary>
///   Represents the color used for the contour of a 3D object, supporting multiple color models.
/// </summary>
[OpenXmlType(typeof(DXD.ContourColor))]
[XmlRoot("ContourColor", Namespace = "DocumentModel.Drawings")]
public partial class ContourColor : DrawingsColorBase<DXD.ContourColor>
{

}