namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an inserted track change in a WordprocessingML document.
/// This interface extends <see cref="TrackChangeType"/> and is used to indicate that content has been inserted as part of tracked changes, enabling revision tracking and review of new content additions within the document.
/// </summary>
public interface Inserted : TrackChangeType
{
}