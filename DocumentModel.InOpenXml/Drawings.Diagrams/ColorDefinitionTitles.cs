namespace DocumentModel.Drawings.Diagrams;
/// <summary>
/// Represents a collection of color definition titles used for organizing or displaying color-related metadata.
/// </summary>
[DataContract]
[XmlRoot("ColorDefinitionTitles", Namespace = "DocumentModel.Drawings.Diagrams")]
public class ColorDefinitionTitles : ModelElementCollection<ColorDefinitionTitle>
{
}