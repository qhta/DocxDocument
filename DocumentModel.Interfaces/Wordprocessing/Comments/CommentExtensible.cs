namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies additional information about comments in the document.
/// This interface provides properties for durable identifiers, UTC date information, intelligent placeholder status, and extension data, enabling advanced tracking, management, and extensibility of comment metadata and behaviors in WordprocessingML documents.
/// </summary>
public interface CommentExtensible
{
  /// <summary>
  /// Identifier for the associated comment. Values must be greater than 0 and less than 0x7FFFFFFF.
  /// </summary>
  public HexInt? DurableId { get; set; }

  /// <summary>
  /// Date information for the comment, defined in the UTC time zone.
  /// </summary>
  public DateTime? DateUtc { get; set; }

  /// <summary>
  /// Indicates whether the comment is a follow-up (intelligent placeholder). If true, the content of the comment should be ignored. Must not be present on comments that are replies.
  /// </summary>
  public bool? IntelligentPlaceholder { get; set; }

  /// <summary>
  /// Additional information about a single comment, provided as an extension list.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}