namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a deleted track change in a WordprocessingML document.
/// This class extends <see cref="TrackChangeType"/> and is used to indicate that content has been deleted as part of tracked changes, enabling revision tracking and review of content removals within the document.
/// </summary>
public class Deleted: TrackChangeType<DXW.Deleted>
{
}