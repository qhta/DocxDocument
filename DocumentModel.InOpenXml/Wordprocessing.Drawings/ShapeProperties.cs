using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the set of visual properties for a shape in a Wordprocessing document.
/// This class provides configuration for geometry, fill, outline, effects, 3D settings, and other visual aspects of a shape.
/// </summary>
[XmlRoot("ShapeProperties", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public class ShapeProperties : DocumentModel.Drawings.ShapeProperties
{
}