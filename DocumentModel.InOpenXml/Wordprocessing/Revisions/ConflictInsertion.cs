namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a conflict insertion track change in a WordprocessingML document.
/// This class extends <see cref="TrackChangeType"/> and is used to indicate that content has been inserted in conflict with edits made by other users, enabling revision tracking and review of conflicting insertions.
/// </summary>
public class ConflictInsertion : TrackChangeType<DXO10W.ConflictInsertion>
{
}