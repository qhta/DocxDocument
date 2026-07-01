namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
///   Reuses core `Drawings.ShapeProperties` (Visual properties like fill, outline, effects) but scoped for chart contexts.
/// </summary>
[OpenXmlType(typeof(DXDCD.ShapeProperties))]
[DataContract]
[XmlRoot("ShapeProperties", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public class ShapeProperties : ModelElement<DXDCD.ShapeProperties>
{
}