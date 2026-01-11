namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the start of a custom XML deletion range in a WordprocessingML document.
/// This interface extends <see cref="TrackChangeType"/> and is used to mark the beginning of a region where custom XML content has been deleted as part of tracked changes, enabling revision tracking and review of custom XML deletions.
/// </summary>
public interface CustomXmlDelRangeStart : TrackChangeType
{
}