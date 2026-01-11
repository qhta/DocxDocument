namespace DocumentModel.Wordprocessing;

/// <summary>
/// Base interface for ParagraphMarkRunProperties classes, containing properties specific to paragraph mark runs that are not applied to <see cref="ExtBaseRunProperties"/>.
/// Provides support for revision tracking, conflict handling, and Office Math indication on paragraph marks.
/// </summary>
public interface BaseParagraphMarkRunProperties : ExtBaseRunProperties
{
    
    /// <summary>
    /// Indicates that the paragraph has been inserted, with revision tracking information.
    /// </summary>
    public TrackChangeType? Inserted { get; set; }
    
    /// <summary>
    /// Indicates that the paragraph has been deleted, with revision tracking information.
    /// </summary>
    public TrackChangeType? Deleted { get; set; }
    
    /// <summary>
    /// Indicates that the paragraph is the source of a move operation, with revision tracking information.
    /// </summary>
    public TrackChangeType? MoveFrom { get; set; }
    
    /// <summary>
    /// Indicates that the paragraph is the destination of a move operation, with revision tracking information.
    /// </summary>
    public TrackChangeType? MoveTo { get; set; }
    
    /// <summary>
    /// Indicates that the paragraph has been inserted in conflict with edits made by other users.
    /// </summary>
    public TrackChangeType2? ConflictInsertion { get; set; }
    
    /// <summary>
    /// Indicates that the paragraph has been deleted in conflict with edits made by other users.
    /// </summary>
    public TrackChangeType2? ConflictDeletion { get; set; }
    
    /// <summary>
    /// Indicates that this run contains WordprocessingML to be handled as Office Open XML Math, allowing equations on empty paragraphs and marking the paragraph as part of an Office Math equation.
    /// </summary>
    public bool? OfficeMath { get; set; }
}