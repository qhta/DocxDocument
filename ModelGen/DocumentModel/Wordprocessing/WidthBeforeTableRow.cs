namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the preferred width for the total number of grid columns before this table row as specified in the gridAfter element.
/// </summary>
public partial class WidthBeforeTableRow: ModelElement<DXW.WidthBeforeTableRow>
{
  public WidthBeforeTableRow(): base(){ }
  
  public WidthBeforeTableRow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WidthBeforeTableRow(DXW.WidthBeforeTableRow openXmlElement): base(openXmlElement) { }
  
}
