namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a conflict deletion track change in a WordprocessingML document.
/// This class extends <see cref = "TrackChangeType2"/> and is used to indicate that content has been deleted in conflict with edits made by other users, enabling revision tracking and review of conflicting deletions.
/// </summary>
[OpenXmlType(typeof(DXO10W.ConflictDeletion))]
[DataContract]
[XmlRoot("ConflictDeletion", Namespace = "DocumentModel.Wordprocessing")]
public class ConflictDeletion : TrackChangeType<DXO10W.ConflictDeletion>
{
}