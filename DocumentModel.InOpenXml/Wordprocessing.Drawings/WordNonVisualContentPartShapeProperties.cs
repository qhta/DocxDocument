namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents non-visual properties for a content part shape in a Wordprocessing document.
/// This class provides access to drawing properties and ink content part properties, enabling configuration and management of non-visual aspects for content part shapes.
/// </summary>
public partial class WordNonVisualContentPartShapeProperties : ModelElement
{
    /// <summary>
    /// Non-visual properties for the drawing element, including identifiers, names, and descriptive information.
    /// </summary>
    public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

    private NonVisualDrawingProperties? _NonVisualDrawingProperties;
    /// <summary>
    /// Non-visual properties specific to ink content parts, such as comment status and content part locks.
    /// </summary>
    public NonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get; set; }
}