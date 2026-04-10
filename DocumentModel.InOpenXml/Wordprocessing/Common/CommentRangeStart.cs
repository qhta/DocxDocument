namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the start of the range around which a comment is anchored in the content of a WordprocessingML document.
/// The Id attribute on this element is used to link the corresponding comment anchor range end element and comment reference, enabling advanced management and referencing of comment ranges within the document content.
/// </summary>
[OpenXmlType(typeof(DXW.CommentRangeStart))]
[XmlRoot("CommentRangeStart", Namespace = "DocumentModel.Wordprocessing")]
public class CommentRangeStart : MarkupStartRangeElement<DXW.CommentRangeStart, DXW.CommentRangeEnd>
{
}