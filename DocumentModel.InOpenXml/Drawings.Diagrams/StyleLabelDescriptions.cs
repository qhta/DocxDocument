namespace DocumentModel.Drawings.Diagrams;
/// <summary>
/// Represents a collection of style label descriptions used to define formatting or labeling information in an Open XML
/// document.
/// </summary>
[XmlRoot("StyleLabelDescriptions", Namespace = "DocumentModel.Drawings.Diagrams")]
public class StyleLabelDescriptions : ModelElementCollection<StyleLabelDescription>
{
}