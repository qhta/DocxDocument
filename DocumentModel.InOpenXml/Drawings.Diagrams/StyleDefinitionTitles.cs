namespace DocumentModel.Drawings.Diagrams;
/// <summary>
/// Represents a collection of style definition titles used for organizing or displaying style-related metadata.
/// </summary>
[XmlRoot("StyleDefinitionTitles", Namespace = "DocumentModel.Drawings.Diagrams")]
public class StyleDefinitionTitles : ModelElementCollection<StyleDefinitionTitle>
{
}