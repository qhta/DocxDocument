namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the beginning of a region in which all custom XML markup has been deleted in conflict with edits made by other users. An application MAY ignore this element.
/// </summary>
public partial class CustomXmlConflictDeletionRangeStart: ModelElement<DXO10W.CustomXmlConflictDeletionRangeStart>
{
  public CustomXmlConflictDeletionRangeStart(): base(){ }
  
  public CustomXmlConflictDeletionRangeStart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlConflictDeletionRangeStart(DXO10W.CustomXmlConflictDeletionRangeStart openXmlElement): base(openXmlElement) { }
  
}
