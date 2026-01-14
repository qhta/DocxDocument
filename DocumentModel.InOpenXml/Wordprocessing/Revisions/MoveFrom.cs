namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a move-from track change marker in a WordprocessingML document.
/// This interface extends <see cref="TrackChangeType"/> and is used to indicate that content has been moved away from its original location as part of tracked changes, enabling revision tracking and review of content relocations within the document.
/// </summary>
public interface MoveFrom : TrackChangeType
{
}