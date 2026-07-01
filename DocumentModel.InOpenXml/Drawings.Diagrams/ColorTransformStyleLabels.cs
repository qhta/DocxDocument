namespace DocumentModel.Drawings.Diagrams;
/// <summary>
/// Represents a collection of color transform style label elements used to define color transformation styles in a
/// document.
/// </summary>
[DataContract]
[XmlRoot("ColorTransformStyleLabels", Namespace = "DocumentModel.Drawings.Diagrams")]
public class ColorTransformStyleLabels : ModelElementCollection<ColorTransformStyleLabel>
{
}