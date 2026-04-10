namespace DocumentModel.Drawings;
/// <summary>
/// Represents a collection of shape guide values used to adjust the geometry of shapes.
/// </summary>
[OpenXmlType(typeof(ShapeGuide))]
[XmlRoot("AdjustValueList", Namespace = "DocumentModel.Drawings")]
public class AdjustValueList : ModelElementCollection<ShapeGuide, DXD.AdjustValueList, DXD.ShapeGuide>
{
}