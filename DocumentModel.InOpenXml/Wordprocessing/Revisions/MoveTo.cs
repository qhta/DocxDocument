namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a move-to track change marker in a WordprocessingML document.
/// This class extends <see cref="TrackChangeType"/> and is used to indicate that content has been moved to a new location as part of tracked changes, enabling revision tracking and review of content relocations within the document.
/// </summary>
public class MoveTo : TrackChangeType<DXW.MoveTo>
{
}