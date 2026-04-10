namespace DocumentModel.Drawings.Diagrams;
/// <summary>
/// Represents a collection of color transform descriptions used to define color transformation operations.
/// </summary>
[XmlRoot("ColorTransformDescriptions", Namespace = "DocumentModel.Drawings.Diagrams")]
public class ColorTransformDescriptions : ModelElementCollection<ColorTransformDescription>
{
}