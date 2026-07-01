namespace DocumentModel.Drawings;
/// <summary>
///   Represents the color used for the extrusion of a 3D object, supporting multiple color models.
/// </summary>
[OpenXmlType(typeof(DXD.ExtrusionColor))]
[XmlRoot("ExtrusionColor", Namespace = "DocumentModel.Drawings")]
public partial class ExtrusionColor : ColorHolder<DXD.ExtrusionColor>
{

}