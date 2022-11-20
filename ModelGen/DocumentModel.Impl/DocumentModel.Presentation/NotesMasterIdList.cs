namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesMasterIdList Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.INotesMasterId))]
public class NotesMasterIdList: INotesMasterIdList
{
  /// <summary>
  /// Notes Master ID.
  /// </summary>
  public INotesMasterId? NotesMasterId
  {
    get;
    set;
  }
  
}
