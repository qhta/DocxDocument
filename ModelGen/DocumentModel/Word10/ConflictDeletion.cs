namespace DocumentModel.Word10;


/// <summary>
///   This element specifies that the parent object has been deleted in conflict with edits made by other users. An application MAY treat the parent as a tracked deletion.
/// </summary>
public partial class ConflictDeletion: ModelElement<DXO10W.ConflictDeletion>
{
  public ConflictDeletion(): base(){ }
  
  public ConflictDeletion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConflictDeletion(DXO10W.ConflictDeletion openXmlElement): base(openXmlElement) { }
  
}
