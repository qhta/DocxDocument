namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the presence of a comment content reference mark, which links the comment content with the contents of a document story. 
///   This link is established by matching the comment whose id attribute matches the id attribute on this element.
///   The resulting comment is anchored to the range with comment range elements with the same id attribute values (if present) as follows: 
///   <list type="bullet">
///     <item>
///       If both of the commentRangeStart and commentRangeEnd elements (§17.13.4.4; §17.13.4.3) are present, then the comment reference shall anchor the comment to the resulting range. 
///     </item>
///     <item>
///       If only one of the commentRangeStart and commentRangeEnd elements (§17.13.4.4; §17.13.4.3) is present, then the document is non-conformant. 
///     </item>
///     <item>
///       If neither element is present, then the comment reference shall anchor the comment to its current location. 
///     </item>
///   </list>
/// </summary>
public class CommentReference : MarkupType, IRunContent
{
}