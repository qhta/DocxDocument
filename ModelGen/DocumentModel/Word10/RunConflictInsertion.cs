namespace DocumentModel.Word10;


/// <summary>
///   This element specifies that the parent object has been inserted in conflict with edits made by other users. An application MAY treat the parent as a tracked insertion.
/// </summary>
public partial class RunConflictInsertion: ModelElement<DXO10W.RunConflictInsertion>
{
  public RunConflictInsertion(): base(){ }
  
  public RunConflictInsertion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RunConflictInsertion(DXO10W.RunConflictInsertion openXmlElement): base(openXmlElement) { }
  
}
