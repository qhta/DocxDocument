namespace DocumentModel.Drawings;
/// <summary>
///   Base type for a color for drawing elements.
///   All drawing color types derive from class..
/// </summary>
[OpenXmlType(typeof(DXD.ColorType))]
[XmlRoot("ColorClass", Namespace = "DocumentModel.Drawings")]
public class ColorClass : AbstractColor<DXD.ColorType>
{
}