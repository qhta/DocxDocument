namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the root element of the CommentsIds part of a WordprocessingML document.
/// This interface provides access to and management of <see cref="CommentId"/> objects, enabling advanced tracking, organization, and persistent identification of comments throughout the document for synchronization and collaborative editing workflows.
/// </summary>
public interface CommentsIds : ElementCollection<CommentId>
{
  
}