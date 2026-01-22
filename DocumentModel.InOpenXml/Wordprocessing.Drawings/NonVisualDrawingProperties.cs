using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents non-visual properties for a drawing element in a Wordprocessing document.
/// This interface provides metadata and configuration for graphical objects, including identifiers, descriptive information, visibility, hyperlinks, and extension data.
/// </summary>
public partial class NonVisualDrawingProperties : ModelElement
{
    /// <summary>
    /// Application-defined unique identifier for the drawing element, used to distinguish it from other elements in the document.
    /// </summary>
    public UInt32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private UInt32? _Id;
    /// <summary>
    /// Name of the drawing element, compatible with the object model but not required to be unique.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Description of the drawing element, providing additional context or information for accessibility and documentation.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Flag indicating whether the drawing element is hidden from view in the document.
    /// </summary>
    public bool? Hidden { get; set; }
    /// <summary>
    /// Title of the drawing element, which may be used for accessibility or as a tooltip.
    /// </summary>
    public string? Title { get; set; }
    /// <summary>
    /// Hyperlink information associated with clicking or selecting the drawing element, enabling navigation or actions.
    /// </summary>
    public HyperlinkOnClick? HyperlinkOnClick { get; set; }
    /// <summary>
    /// Hyperlink information associated with hovering over the drawing element, enabling navigation or actions on mouse-over.
    /// </summary>
    public HyperlinkOnHover? HyperlinkOnHover { get; set; }
    /// <summary>
    /// List of extensions for future or custom non-visual drawing properties, allowing for extensibility.
    /// </summary>
    public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get; set; }
}