namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies inline-level content that has been inserted in conflict with edits made by other users. 
///   An application MAY treat the content as a tracked insertion. 
/// </summary>
public class RunConflictInsertion: RunTrackChangeType
{
}