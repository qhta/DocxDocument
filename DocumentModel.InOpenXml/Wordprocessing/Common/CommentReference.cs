namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies the presence of a comment content reference mark, which links the comment content with the contents of a document story.
///   The link is established by matching the comment whose id attribute matches the id attribute on this element. The comment is anchored to the range with comment range elements with the same id attribute values, or to the current location if no range elements are present.
/// </summary>
[OpenXmlType(typeof(DXW.CommentReference))]
[XmlRoot("CommentReference", Namespace = "DocumentModel.Wordprocessing")]
public class CommentReference : ModelElement<DXW.CommentReference>, IMarkupElement, IRunContent
{
}