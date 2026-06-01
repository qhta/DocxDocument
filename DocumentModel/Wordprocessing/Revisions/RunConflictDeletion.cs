namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies inline-level content 
///   Ithat has been deleted Iin conflict with edits made by other users. 
///   An application MAY treat the content as a tracked deletion. 
/// </summary>
public class RunConflictDeletion: RunTrackChangeType
{
}
