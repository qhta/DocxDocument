namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies inline-level content that has been deleted in conflict with edits made by other users. An application MAY treat the content as a tracked deletion.
/// </summary>
public partial class RunConflictDeletion
{
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
