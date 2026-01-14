namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the start of a custom XML move-to range in a WordprocessingML document.
/// This interface extends <see cref="TrackChangeType"/> and is used to mark the beginning of a region where custom XML content has been moved to a new location as part of tracked changes, enabling revision tracking and review of custom XML moves.
/// </summary>
public interface CustomXmlMoveToRangeStart : TrackChangeType
{
}