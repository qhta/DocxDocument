namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies additional information about comments in the document.
/// This class provides properties for durable identifiers, UTC date information, intelligent placeholder status, and extension data, enabling advanced tracking, management, and extensibility of comment metadata and behaviors in WordprocessingML documents.
/// </summary>
[OpenXmlType(typeof(DXO21WCE.CommentExtensible))]
public partial class CommentExtensible : ModelElement<DXO21WCE.CommentExtensible>
{
 /// <summary>
 /// Identifier for the associated comment. Values must be greater than 0 and less than 0x7FFFFFFF.
 /// </summary>
 [OpenXmlProperty(nameof(DXO21WCE.CommentExtensible.DurableId))]
 [OpenXmlElement(typeof(DXO21WCE.CommentExtensible))]
 public HexInt? DurableId { get => _DurableId; set => UpdateField(ref _DurableId, value, nameof(DurableId)); }

 private HexInt? _DurableId;
 /// <summary>
 /// Date information for the comment, defined in the UTC time zone.
 /// </summary>
 [OpenXmlProperty(nameof(DXO21WCE.CommentExtensible.DateUtc))]
 [OpenXmlElement(typeof(DXO21WCE.CommentExtensible))]
 public DateTime? DateUtc { get => _DateUtc; set => UpdateField(ref _DateUtc, value, nameof(DateUtc)); }

 private DateTime? _DateUtc;
 /// <summary>
 /// Indicates whether the comment is a follow-up (intelligent placeholder). If true, the content of the comment should be ignored. Must not be present on comments that are replies.
 /// </summary>
 [OpenXmlProperty(nameof(DXO21WCE.CommentExtensible.IntelligentPlaceholder))]
 [OpenXmlElement(typeof(DXO21WCE.CommentExtensible))]
 public bool? IntelligentPlaceholder { get => _IntelligentPlaceholder; set => UpdateField(ref _IntelligentPlaceholder, value, nameof(IntelligentPlaceholder)); }

 private bool? _IntelligentPlaceholder;
 /// <summary>
 /// Additional information about a single comment, provided as an extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO21WCE.CommentExtensible.ExtensionList))]
 [OpenXmlElement(typeof(DXO21WCE.CommentExtensible))]
 public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private IExtensionList? _ExtensionList;
}