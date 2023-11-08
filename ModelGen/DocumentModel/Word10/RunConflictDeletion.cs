namespace DocumentModel.Word10;


/// <summary>
///   This element specifies inline-level content that has been deleted in conflict with edits made by other users. An application MAY treat the content as a tracked deletion.
/// </summary>
public partial class RunConflictDeletion: ModelElement<DXO10W.RunConflictDeletion>
{
  public RunConflictDeletion(): base(){ }
  
  public RunConflictDeletion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RunConflictDeletion(DXO10W.RunConflictDeletion openXmlElement): base(openXmlElement) { }
  
}
