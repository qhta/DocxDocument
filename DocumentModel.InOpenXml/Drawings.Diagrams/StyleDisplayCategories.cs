namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Category List.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDisplayCategories))]
[XmlRoot("StyleDisplayCategories", Namespace = "DocumentModel.Drawings.Diagrams")]
public class StyleDisplayCategories : ModelElementCollection<StyleDisplayCategory, DXDD.StyleDisplayCategories, DXDD.StyleDisplayCategory>
{
}