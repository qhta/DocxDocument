namespace DocumentModel.Word10;


/// <summary>
///   When true, specifies that the user was resolving conflicting edits when the document was saved.
/// </summary>
public partial class ConflictMode: ModelElement<DXO10W.ConflictMode>
{
  public ConflictMode(): base(){ }
  
  public ConflictMode(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConflictMode(DXO10W.ConflictMode openXmlElement): base(openXmlElement) { }
  
}
