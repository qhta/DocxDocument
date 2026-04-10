namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the root element of the CommentsIds part of a WordprocessingML document.
/// This class provides access to and management of <see cref = "CommentId"/> objects, enabling advanced tracking, organization, and persistent identification of comments throughout the document for synchronization and collaborative editing workflows.
/// </summary>
[OpenXmlType(typeof(CommentId))]
[XmlRoot("CommentsIds", Namespace = "DocumentModel.Wordprocessing")]
public class CommentsIds : ModelElementCollection<CommentId, DXO19WC.CommentsIds, DXO19WC.CommentId>
{
}