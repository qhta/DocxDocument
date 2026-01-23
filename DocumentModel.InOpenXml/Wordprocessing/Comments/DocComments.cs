namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies all of the comments defined in the current WordprocessingML document.
/// This class provides properties for collections of comments, extended comments, comment identifiers, and extensible comments, enabling advanced tracking, organization, and management of comment metadata and content throughout the document.
/// </summary>
public partial class DocComments : ModelElement
{
    /// <summary>
    /// Collection of comments, providing access to standard comment annotations in the document.
    /// </summary>
    public Comments? Comments { get => _Comments; set => UpdateField(ref _Comments, value, nameof(Comments)); }

    private Comments? _Comments;
    /// <summary>
    /// Collection of extended comments, providing access to additional metadata and behaviors for comments.
    /// </summary>
    public CommentsEx? CommentsEx { get => _CommentsEx; set => UpdateField(ref _CommentsEx, value, nameof(CommentsEx)); }

    private CommentsEx? _CommentsEx;
    /// <summary>
    /// Collection of comment identifiers, enabling persistent and stable references to comments for tracking and synchronization.
    /// </summary>
    public CommentsIds? CommentsIds { get => _CommentsIds; set => UpdateField(ref _CommentsIds, value, nameof(CommentsIds)); }

    private CommentsIds? _CommentsIds;
    /// <summary>
    /// Collection of extensible comments, supporting advanced extensibility and custom metadata for comments.
    /// </summary>
    public CommentsExtensible? CommentsExtensible { get => _CommentsExtensible; set => UpdateField(ref _CommentsExtensible, value, nameof(CommentsExtensible)); }

    private CommentsExtensible? _CommentsExtensible;
}