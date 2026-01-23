namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents settings for freezing the document layout in read mode for ink content in a Wordprocessing document.
/// This class provides properties for controlling page usage, virtual page dimensions, and font size scaling, enabling consistent rendering and layout preservation when displaying ink annotations or drawings.
/// </summary>
public partial class ReadModeInkLockDown : ModelElement
{
    /// <summary>
    /// Indicates whether actual pages are used instead of virtual pages for layout, affecting how ink content is rendered and paginated.
    /// </summary>
    public bool? UseActualPages { get => _UseActualPages; set => UpdateField(ref _UseActualPages, value, nameof(UseActualPages)); }

    private bool? _UseActualPages;
    /// <summary>
    /// The width of the virtual page, specified in units relevant to the document, used for layout calculations in read mode.
    /// </summary>
    public UInt32? Width { get; set; }
    /// <summary>
    /// The height of the virtual page, specified in units relevant to the document, used for layout calculations in read mode.
    /// </summary>
    public UInt32? Height { get; set; }
    /// <summary>
    /// The scaling factor for font size, specified as a string, used to adjust text size for consistent appearance in read mode.
    /// </summary>
    public string? FontSize { get; set; }
}