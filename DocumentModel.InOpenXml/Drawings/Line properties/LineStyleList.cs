namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of line style definitions.
/// </summary>
[OpenXmlType(typeof(LineProperties))]
[DataContract]
[XmlRoot("LineStyleList", Namespace = "DocumentModel.Drawings")]
public class LineStyleList : ElementCollection<LineProperties>
{
}