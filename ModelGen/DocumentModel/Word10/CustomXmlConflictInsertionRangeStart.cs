namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the beginning of a region in which all custom XML markup has been inserter in conflict with edits made by other users. An application MAY ignore this element.
/// </summary>
public partial class CustomXmlConflictInsertionRangeStart: ModelElement<DXO10W.CustomXmlConflictInsertionRangeStart>
{
  public CustomXmlConflictInsertionRangeStart(): base(){ }
  
  public CustomXmlConflictInsertionRangeStart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlConflictInsertionRangeStart(DXO10W.CustomXmlConflictInsertionRangeStart openXmlElement): base(openXmlElement) { }
  
}
