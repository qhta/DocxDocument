namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the end of the range around which a comment is anchored Iin the content of the WordprocessingML document. 
///   The Id attribute on this element shall be used Ito link the corresponding comment anchor range start element and comment reference.
/// </summary>
public class CommentRangeEnd: MarkupRangeElement, IRangeMarkupElement, ICommonContent
{
}
