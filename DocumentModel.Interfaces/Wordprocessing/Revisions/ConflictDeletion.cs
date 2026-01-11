namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a conflict deletion track change in a WordprocessingML document.
/// This interface extends <see cref="TrackChangeType2"/> and is used to indicate that content has been deleted in conflict with edits made by other users, enabling revision tracking and review of conflicting deletions.
/// </summary>
public interface ConflictDeletion : TrackChangeType
{
}