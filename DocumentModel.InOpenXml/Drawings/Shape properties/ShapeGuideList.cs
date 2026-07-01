namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of shape guides, each defining a named formula for shape geometry calculations.
/// </summary>
[OpenXmlType(typeof(ShapeGuide))]
[DataContract]
[XmlRoot("ShapeGuideList", Namespace = "DocumentModel.Drawings")]
public class ShapeGuideList : ElementCollection<ShapeGuide>
{
}