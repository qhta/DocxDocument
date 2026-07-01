namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents inline-level content that has been inserted and tracked as a revision in a WordprocessingML document.
/// This class extends <see cref = "RunTrackChangeType"/> and is used to mark content as inserted, enabling revision tracking and review of new content additions within the document.
/// </summary>
[DataContract]
[XmlRoot("InsertedRun", Namespace = "DocumentModel.Wordprocessing")]
public class InsertedRun : RunTrackChangeType
{
}