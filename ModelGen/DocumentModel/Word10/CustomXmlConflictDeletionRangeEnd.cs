namespace DocumentModel.Word10;


/// <summary>
///   A Markup element specifies the end of a region in which all custom XML markup has been deleted in conflict with edits made by other users. An application MAY ignore this element.
/// </summary>
public partial class CustomXmlConflictDeletionRangeEnd: ModelElement<DXO10W.CustomXmlConflictDeletionRangeEnd>
{
  public CustomXmlConflictDeletionRangeEnd(): base(){ }
  
  public CustomXmlConflictDeletionRangeEnd(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlConflictDeletionRangeEnd(DXO10W.CustomXmlConflictDeletionRangeEnd openXmlElement): base(openXmlElement) { }
  
}
