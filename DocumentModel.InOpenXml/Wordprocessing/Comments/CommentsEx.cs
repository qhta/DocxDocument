namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the root element of the CommentsExtended part of a WordprocessingML document.
/// This class provides access to and management of <see cref = "CommentEx"/> objects, enabling advanced tracking, organization, and management of extended comment metadata and behaviors throughout the document.
/// </summary>
[OpenXmlType(typeof(CommentEx))]
[XmlRoot("CommentsEx", Namespace = "DocumentModel.Wordprocessing")]
public class CommentsEx : ElementCollection<CommentEx>
{
}