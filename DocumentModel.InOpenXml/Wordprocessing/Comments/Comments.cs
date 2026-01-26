namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the root element of the Comments part of a WordprocessingML document.
/// This class provides access to and management of <see cref = "Comment"/> objects, enabling advanced tracking, organization, and collaborative review of comments throughout the document.
/// </summary>
[OpenXmlType(typeof(Comment))]
public class Comments : ModelElementCollection<Comment, DXW.Comments, DXW.Comment>
{
}