namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the start of the range around which a comment is anchored in the content of the WordprocessingML document. 
///   The Id attribute on this element shall be used to link the corresponding comment anchor range end element and comment reference. 
/// </summary>
public class CommentRangeStart: MarkupRangeElement, IRangeMarkupElement, ICommonContent
{
}