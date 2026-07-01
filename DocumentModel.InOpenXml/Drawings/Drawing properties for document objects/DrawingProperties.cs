namespace DocumentModel.Drawings;
/// <summary>
///   Collects drawing properties for a document object.
/// </summary>
[OpenXmlType(typeof(IDrawingProperty))]
[DataContract]
[XmlRoot("DrawingProperties", Namespace = "DocumentModel.Drawings")]
public class DrawingProperties : ElementCollection<IDrawingProperty>
{
}