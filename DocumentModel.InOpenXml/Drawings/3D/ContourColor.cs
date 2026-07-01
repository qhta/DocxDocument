namespace DocumentModel.Drawings;
/// <summary>
///   Represents the color used for the contour of a 3D object, supporting multiple color models.
/// </summary>
[OpenXmlType(typeof(DXD.ContourColor))]
[DataContract]
[XmlRoot("ContourColor", Namespace = "DocumentModel.Drawings")]
public partial class ContourColor : ColorHolder<DXD.ContourColor>
{

}