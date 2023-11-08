namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the preferred width for the total number of grid columns after this table row as specified in the gridAfter element.
/// </summary>
public partial class WidthAfterTableRow: ModelElement<DXW.WidthAfterTableRow>
{
  public WidthAfterTableRow(): base(){ }
  
  public WidthAfterTableRow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WidthAfterTableRow(DXW.WidthAfterTableRow openXmlElement): base(openXmlElement) { }
  
}
