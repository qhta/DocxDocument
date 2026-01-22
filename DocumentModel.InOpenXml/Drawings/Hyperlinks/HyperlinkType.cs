namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hyperlink in a drawing object, including relationship information, navigation behavior, and optional sound.
/// </summary>
public partial class HyperlinkType : ModelElement<DXD.HyperlinkType>, IExtendableHyperlinkElement
{
    /// <summary>
    ///   Relationship identifier used to find the target UriString.
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   Stores the URL if it is invalid and a relationship cannot be created; r:id will point to a NULL relationship.
    /// </summary>
    public string? InvalidUrl { get; set; }
    /// <summary>
    ///   Action to take when the hyperlink is activated; may require r:id to specify an action target.
    /// </summary>
    public string? Action { get; set; }
    /// <summary>
    ///   Target frame for navigating to the UriString.
    /// </summary>
    public string? TargetFrame { get; set; }
    /// <summary>
    ///   Tooltip text for display.
    /// </summary>
    public string? Tooltip { get; set; }
    /// <summary>
    ///   Indicates whether to add this UriString to the navigation history.
    /// </summary>
    public bool? History { get; set; }
    /// <summary>
    ///   Indicates whether to highlight the hyperlink when a shape is clicked.
    /// </summary>
    public bool? HighlightClick { get; set; }
    /// <summary>
    ///   Indicates whether to stop any previous sound when the hyperlink is clicked.
    /// </summary>
    public bool? EndSound { get; set; }
    /// <summary>
    ///   Sound to play when the hyperlink is activated.
    /// </summary>
    public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }
    public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}