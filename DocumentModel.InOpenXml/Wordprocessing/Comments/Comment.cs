namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single comment annotation stored in the Comments part of a WordprocessingML document.
/// This interface extends <see cref="CollectionItem"/> and <see cref="ElementCollection{CommentContent}"/>, providing properties for unique identification, author attribution, initials, creation/modification date, paragraph identifier, and durable identifier. Enables advanced tracking, management, and collaborative review of comments, supporting rich text, threaded discussions, and persistent references across document versions and platforms.
/// </summary>
public interface Comment: ICollectionItem, IElementCollection<ICommentContent>
{
    
    /// <summary>
    /// Unique identifier for this comment annotation, used to link comment range markers, associate replies, and reference comments in revision tracking.
    /// </summary>
    public string? Id { get; set; }
    
    /// <summary>
    /// Name of the author who created this comment, displayed in the comment balloon and review pane for attribution.
    /// </summary>
    public string? Author { get; set; }
    
    /// <summary>
    /// Initials of the comment author, providing a compact representation for display in user interfaces and comment blocks.
    /// </summary>
    public string? Initials { get; set; }
    
    /// <summary>
    /// Date and time when this comment was created or last modified, providing temporal context for document review activities.
    /// </summary>
    public DateTime? Date { get; set; }
    
    /// <summary>
    /// Hexadecimal identifier of the first paragraph in the comment content, used for tracking paragraph-level changes and synchronization.
    /// </summary>
    public HexInt? ParaId { get; set; }
    
    /// <summary>
    /// Durable identifier that persists across document versions and platforms, supporting consistent comment tracking and synchronization.
    /// </summary>
    public HexInt? DurableId { get; set; }
}