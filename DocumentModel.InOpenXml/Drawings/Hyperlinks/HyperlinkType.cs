namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hyperlink in a drawing object, including relationship information, navigation behavior, and optional sound.
/// </summary>
public partial class HyperlinkType : ModelElement<DXD.HyperlinkType>, IExtendableHyperlinkElement
{
    /// <summary>
    ///   Relationship identifier used to find the target UriString.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.HyperlinkType.Id))]
    /// <summary>
    ///   Relationship identifier used to find the target UriString.
    /// </summary>
    [OpenXmlElement(typeof(DXD.HyperlinkType))]
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   Stores the URL if it is invalid and a relationship cannot be created; r:id will point to a NULL relationship.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.HyperlinkType.InvalidUrl))]
    /// <summary>
    ///   Stores the URL if it is invalid and a relationship cannot be created; r:id will point to a NULL relationship.
    /// </summary>
    [OpenXmlElement(typeof(DXD.HyperlinkType))]
    public string? InvalidUrl { get => _InvalidUrl; set => UpdateField(ref _InvalidUrl, value, nameof(InvalidUrl)); }

    private string? _InvalidUrl;
    /// <summary>
    ///   Action to take when the hyperlink is activated; may require r:id to specify an action target.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.HyperlinkType.Action))]
    /// <summary>
    ///   Action to take when the hyperlink is activated; may require r:id to specify an action target.
    /// </summary>
    [OpenXmlElement(typeof(DXD.HyperlinkType))]
    public string? Action { get => _Action; set => UpdateField(ref _Action, value, nameof(Action)); }

    private string? _Action;
    /// <summary>
    ///   Target frame for navigating to the UriString.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.HyperlinkType.TargetFrame))]
    /// <summary>
    ///   Target frame for navigating to the UriString.
    /// </summary>
    [OpenXmlElement(typeof(DXD.HyperlinkType))]
    public string? TargetFrame { get => _TargetFrame; set => UpdateField(ref _TargetFrame, value, nameof(TargetFrame)); }

    private string? _TargetFrame;
    /// <summary>
    ///   Tooltip text for display.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.HyperlinkType.Tooltip))]
    /// <summary>
    ///   Tooltip text for display.
    /// </summary>
    [OpenXmlElement(typeof(DXD.HyperlinkType))]
    public string? Tooltip { get => _Tooltip; set => UpdateField(ref _Tooltip, value, nameof(Tooltip)); }

    private string? _Tooltip;
    /// <summary>
    ///   Indicates whether to add this UriString to the navigation history.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.HyperlinkType.History))]
    /// <summary>
    ///   Indicates whether to add this UriString to the navigation history.
    /// </summary>
    [OpenXmlElement(typeof(DXD.HyperlinkType))]
    public bool? History { get => _History; set => UpdateField(ref _History, value, nameof(History)); }

    private bool? _History;
    /// <summary>
    ///   Indicates whether to highlight the hyperlink when a shape is clicked.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.HyperlinkType.HighlightClick))]
    /// <summary>
    ///   Indicates whether to highlight the hyperlink when a shape is clicked.
    /// </summary>
    [OpenXmlElement(typeof(DXD.HyperlinkType))]
    public bool? HighlightClick { get => _HighlightClick; set => UpdateField(ref _HighlightClick, value, nameof(HighlightClick)); }

    private bool? _HighlightClick;
    /// <summary>
    ///   Indicates whether to stop any previous sound when the hyperlink is clicked.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.HyperlinkType.EndSound))]
    /// <summary>
    ///   Indicates whether to stop any previous sound when the hyperlink is clicked.
    /// </summary>
    [OpenXmlElement(typeof(DXD.HyperlinkType))]
    public bool? EndSound { get => _EndSound; set => UpdateField(ref _EndSound, value, nameof(EndSound)); }

    private bool? _EndSound;
    /// <summary>
    ///   Sound to play when the hyperlink is activated.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.HyperlinkType.HyperlinkSound))]
    /// <summary>
    ///   Sound to play when the hyperlink is activated.
    /// </summary>
    [OpenXmlElement(typeof(DXD.HyperlinkType))]
    public EmbeddedWavAudioFileType? HyperlinkSound { get => _HyperlinkSound; set => UpdateField(ref _HyperlinkSound, value, nameof(HyperlinkSound)); }

    private EmbeddedWavAudioFileType? _HyperlinkSound;
    [OpenXmlProperty(nameof(DXD.HyperlinkType.HyperlinkExtensionList))]
    [OpenXmlElement(typeof(DXD.HyperlinkType))]
    public HyperlinkExtensionList? HyperlinkExtensionList { get => _HyperlinkExtensionList; set => UpdateField(ref _HyperlinkExtensionList, value, nameof(HyperlinkExtensionList)); }

    private HyperlinkExtensionList? _HyperlinkExtensionList;
}