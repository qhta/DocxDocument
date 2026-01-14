namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the start of a custom XML insertion range in a WordprocessingML document.
/// This interface extends <see cref="TrackChangeType"/> and is used to mark the beginning of a region where custom XML content has been inserted as part of tracked changes, enabling revision tracking and review of custom XML insertions.
/// </summary>
public interface CustomXmlInsRangeStart : TrackChangeType
{
}