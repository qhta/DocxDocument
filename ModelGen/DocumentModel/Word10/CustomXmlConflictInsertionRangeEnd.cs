namespace DocumentModel.Word10;


/// <summary>
///   A Markup element specifies the end of a region in which all custom XML markup has been inserted in conflict with edits made by other users. An application MAY ignore this element.
/// </summary>
public partial class CustomXmlConflictInsertionRangeEnd: ModelElement<DXO10W.CustomXmlConflictInsertionRangeEnd>
{
  public CustomXmlConflictInsertionRangeEnd(): base(){ }
  
  public CustomXmlConflictInsertionRangeEnd(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlConflictInsertionRangeEnd(DXO10W.CustomXmlConflictInsertionRangeEnd openXmlElement): base(openXmlElement) { }
  
}
