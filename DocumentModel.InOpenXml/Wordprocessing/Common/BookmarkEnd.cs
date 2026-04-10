namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the end marker of a bookmark in a WordprocessingML document.
/// This class extends <see cref = "MarkupRangeElement"/> and <see cref = "ICommonContent"/>, and is used to pair with a corresponding <see cref = "BookmarkStart"/> element, marking the end of a bookmarked range within the document content.
/// </summary>
[OpenXmlType(typeof(DXW.BookmarkEnd))]
[XmlRoot("BookmarkEnd", Namespace = "DocumentModel.Wordprocessing")]
public class BookmarkEnd : MarkupEndRangeElement<DXW.BookmarkEnd, DXW.BookmarkStart>, ICommonContent
{
}