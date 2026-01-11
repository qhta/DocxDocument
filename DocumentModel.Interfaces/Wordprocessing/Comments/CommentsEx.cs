namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the root element of the CommentsExtended part of a WordprocessingML document.
/// This interface provides access to and management of <see cref="CommentEx"/> objects, enabling advanced tracking, organization, and management of extended comment metadata and behaviors throughout the document.
/// </summary>
public interface CommentsEx : ElementCollection<CommentEx>
{
    
}