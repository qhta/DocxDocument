namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents inline-level content that has been deleted and tracked as a revision in a WordprocessingML document.
/// This class extends <see cref="RunTrackChangeType"/> and is used to mark content as deleted, enabling revision tracking and review of content removals within the document.
/// </summary>
public class DeletedRun : RunTrackChangeType
{
}