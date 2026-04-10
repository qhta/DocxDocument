namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a collection of shape elements within a Wordprocessing document.
/// This class provides access to and management of <see cref = "Shape"/> objects, which are graphical elements embedded in the document.
/// </summary>
[OpenXmlType(typeof(Shape))]
[XmlRoot("Shapes", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public class Shapes : ElementCollection<Shape>
{
}