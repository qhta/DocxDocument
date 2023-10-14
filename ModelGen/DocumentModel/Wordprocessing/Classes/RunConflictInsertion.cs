namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the parent object has been inserted in conflict with edits made by other users. An application MAY treat the parent as a tracked insertion.
/// </summary>
public partial class RunConflictInsertion
{
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
