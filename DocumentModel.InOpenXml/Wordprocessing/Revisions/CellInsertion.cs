namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a cell insertion track change in a WordprocessingML document.
/// This interface extends <see cref="TrackChangeType"/> and is used to indicate that a table cell has been inserted as part of tracked changes, enabling revision tracking and review of cell insertions in tables.
/// </summary>
public interface CellInsertion : TrackChangeType
{
}