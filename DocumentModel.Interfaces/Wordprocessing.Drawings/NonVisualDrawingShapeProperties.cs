using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents non-visual properties for a drawing shape in a Wordprocessing document.
/// This interface provides configuration for text box behavior, shape locking, and extension data, enabling control over shape interaction and extensibility.
/// </summary>
public interface NonVisualDrawingShapeProperties: ExtendableElement
{
    /// <summary>
    /// Indicates whether the shape functions as a text box, allowing text to be contained within the shape.
    /// </summary>
    public bool? TextBox { get; set; }
    /// <summary>
    /// The set of locks applied to the shape, restricting modifications or interactions as defined by the document.
    /// </summary>
    public ShapeLocks? ShapeLocks { get; set; }
}