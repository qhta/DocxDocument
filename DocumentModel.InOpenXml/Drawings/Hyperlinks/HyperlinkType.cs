namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hyperlink in a DrawingML object, including relationship information, navigation behavior, tooltip, and optional sound or extension data.
///   Enables linking shapes, images, or other drawing elements to external or internal targets with advanced navigation and interaction options.
/// </summary>
[OpenXmlType(typeof(DXD.HyperlinkType))]
[XmlRoot("HyperlinkType", Namespace = "DocumentModel.Drawings")]
public partial class HyperlinkType : ModelElement<DXD.HyperlinkType>, IExtendableHyperlinkElement
{
 /// <summary>
 ///   Relationship identifier used to resolve the target URI for the hyperlink.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkType.Id))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private string? _Id;

 /// <summary>
 ///   Stores the URL if it is invalid and a relationship cannot be created; <c>r:id</c> will point to a NULL relationship.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkType.InvalidUrl))]
 public string? InvalidUrl { get => _InvalidUrl; set => UpdateField(ref _InvalidUrl, value, nameof(InvalidUrl)); }
 private string? _InvalidUrl;

 /// <summary>
 ///   Action to take when the hyperlink is activated; may require <c>r:id</c> to specify an action target (e.g., run a macro or script).
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkType.Action))]
 public string? Action { get => _Action; set => UpdateField(ref _Action, value, nameof(Action)); }
 private string? _Action;

 /// <summary>
 ///   Target frame or window for navigating to the hyperlink URI (e.g., <c>_blank</c>, <c>_self</c>).
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkType.TargetFrame))]
 public string? TargetFrame { get => _TargetFrame; set => UpdateField(ref _TargetFrame, value, nameof(TargetFrame)); }
 private string? _TargetFrame;

 /// <summary>
 ///   Tooltip text to display when hovering over the hyperlink.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkType.Tooltip))]
 public string? Tooltip { get => _Tooltip; set => UpdateField(ref _Tooltip, value, nameof(Tooltip)); }
 private string? _Tooltip;

 /// <summary>
 ///   Indicates whether to add this hyperlink's URI to the navigation history.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkType.History))]
 public bool? History { get => _History; set => UpdateField(ref _History, value, nameof(History)); }
 private bool? _History;

 /// <summary>
 ///   Indicates whether to highlight the hyperlink when the associated shape is clicked.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkType.HighlightClick))]
 public bool? HighlightClick { get => _HighlightClick; set => UpdateField(ref _HighlightClick, value, nameof(HighlightClick)); }
 private bool? _HighlightClick;

 /// <summary>
 ///   Indicates whether to stop any previous sound when the hyperlink is clicked.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkType.EndSound))]
 public bool? EndSound { get => _EndSound; set => UpdateField(ref _EndSound, value, nameof(EndSound)); }
 private bool? _EndSound;

 /// <summary>
 ///   Embedded sound to play when the hyperlink is activated.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkType.HyperlinkSound))]
 public EmbeddedWavAudioFileType? HyperlinkSound { get => _HyperlinkSound; set => UpdateField(ref _HyperlinkSound, value, nameof(HyperlinkSound)); }
 private EmbeddedWavAudioFileType? _HyperlinkSound;

 /// <summary>
 ///   List of extension elements for the hyperlink, supporting extensibility and application-specific hyperlink data.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkType.HyperlinkExtensionList))]
 public HyperlinkExtensionList? HyperlinkExtensionList { get => _HyperlinkExtensionList; set => UpdateField(ref _HyperlinkExtensionList, value, nameof(HyperlinkExtensionList)); }
 private HyperlinkExtensionList? _HyperlinkExtensionList;
}