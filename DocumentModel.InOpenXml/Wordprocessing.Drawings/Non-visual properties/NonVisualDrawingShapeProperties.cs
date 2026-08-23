namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents non-visual properties for a drawing shape in a Wordprocessing document.
/// This class provides configuration for text box behavior, shape locking, and extension data, enabling control over shape interaction and extensibility.
/// </summary>
[OpenXmlType(typeof(DXOD.NonVisualDrawingShapeProperties))]
[DataContract]
[XmlRoot("NonVisualDrawingShapeProperties", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class NonVisualDrawingShapeProperties : DMD.NonVisualDrawingShapeProperties<DXOD.NonVisualDrawingShapeProperties>
{
}