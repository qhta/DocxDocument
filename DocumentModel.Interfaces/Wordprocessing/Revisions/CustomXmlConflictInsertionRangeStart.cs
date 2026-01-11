namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the start of a custom XML conflict insertion range in a WordprocessingML document.
/// This interface extends <see cref="TrackChangeType"/> and is used to mark the beginning of a region where custom XML content has been inserted in conflict with other changes, enabling revision tracking and review of conflicting custom XML insertions.
/// </summary>
public interface CustomXmlConflictInsertionRangeStart : TrackChangeType
{
}