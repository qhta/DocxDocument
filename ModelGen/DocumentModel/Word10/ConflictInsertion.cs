namespace DocumentModel.Word10;


/// <summary>
///   This element specifies that the parent object has been inserted in conflict with edits made by other users. An application MAY treat the parent as a tracked insertion.
/// </summary>
public partial class ConflictInsertion: ModelElement<DXO10W.ConflictInsertion>
{
  public ConflictInsertion(): base(){ }
  
  public ConflictInsertion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConflictInsertion(DXO10W.ConflictInsertion openXmlElement): base(openXmlElement) { }
  
}
