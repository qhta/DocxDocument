namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies additional information about comments in the document.
/// </summary>
public class CommentExtensible: ModelElement
{
  /// <summary>
  ///   Specifies the identifier for the associated comment. Values MUST be greater than 0 and less than 0x7FFFFFFF.
  /// </summary>
  public IHexInt? DurableId { get; set; }
  /// <summary>
  ///   Specifies date information for the comment. Unlike the date attribute of a comment element, 
  ///   the dateUtc attribute is defined to be in the UTC time zone.
  /// </summary>
  public DateTime? DateUtc { get; set; }
  /// <summary>
  ///   When true specifies that the comment is a follow-up. 
  ///   The default value is false. 
  ///   The attribute MUST NOT be present on comments that are replies as specified by the paraIdParent attribute 
  ///   of an associated element of type CT_CommentEx.
  ///   When intelligentPlaceholder is true, the content of the comment SHOULD be ignored.
  /// </summary>
  public bool? IntelligentPlaceholder { get; set; }
  /// <summary>
  ///   Specifies additional information about a single comment.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}