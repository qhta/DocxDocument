namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents inline-level content that has been moved away from this location and tracked as a revision in a WordprocessingML document.
/// This class extends <see cref = "RunTrackChangeType"/> and is used to mark content as moved from its original location, enabling revision tracking and review of content relocations within the document.
/// </summary>
[DataContract]
[XmlRoot("MoveFromRun", Namespace = "DocumentModel.Wordprocessing")]
public class MoveFromRun : RunTrackChangeType
{
}