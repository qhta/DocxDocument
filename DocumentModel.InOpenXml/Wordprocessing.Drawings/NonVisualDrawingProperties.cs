using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents non-visual properties for a drawing element in a Wordprocessing document.
/// This class provides metadata and configuration for graphical objects, including identifiers, descriptive information, visibility, hyperlinks, and extension data.
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
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    /// Description of the drawing element, providing additional context or information for accessibility and documentation.
    /// </summary>
    public string? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }

    private string? _Description;
    /// <summary>
    /// Flag indicating whether the drawing element is hidden from view in the document.
    /// </summary>
    public bool? Hidden { get => _Hidden; set => UpdateField(ref _Hidden, value, nameof(Hidden)); }

    private bool? _Hidden;
    /// <summary>
    /// Title of the drawing element, which may be used for accessibility or as a tooltip.
    /// </summary>
    public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

    private string? _Title;
    /// <summary>
    /// Hyperlink information associated with clicking or selecting the drawing element, enabling navigation or actions.
    /// </summary>
    public HyperlinkOnClick? HyperlinkOnClick { get => _HyperlinkOnClick; set => UpdateField(ref _HyperlinkOnClick, value, nameof(HyperlinkOnClick)); }

    private HyperlinkOnClick? _HyperlinkOnClick;
    /// <summary>
    /// Hyperlink information associated with hovering over the drawing element, enabling navigation or actions on mouse-over.
    /// </summary>
    public HyperlinkOnHover? HyperlinkOnHover { get => _HyperlinkOnHover; set => UpdateField(ref _HyperlinkOnHover, value, nameof(HyperlinkOnHover)); }

    private HyperlinkOnHover? _HyperlinkOnHover;
    /// <summary>
    /// List of extensions for future or custom non-visual drawing properties, allowing for extensibility.
    /// </summary>
    public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get => _NonVisualDrawingPropertiesExtensionList; set => UpdateField(ref _NonVisualDrawingPropertiesExtensionList, value, nameof(NonVisualDrawingPropertiesExtensionList)); }

    private NonVisualDrawingPropertiesExtensionList? _NonVisualDrawingPropertiesExtensionList;
}