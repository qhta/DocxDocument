namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the start of a custom XML move-from range in a WordprocessingML document.
/// This interface extends <see cref="TrackChangeType"/> and is used to mark the beginning of a region where custom XML content has been moved from its original location as part of tracked changes, enabling revision tracking and review of custom XML moves.
/// </summary>
public interface CustomXmlMoveFromRangeStart : TrackChangeType
{
}