namespace DocumentModel.Wordprocessing;


/// <summary>
///   Align Table Rows Independently.
/// </summary>
public partial class AlignTablesRowByRow: ModelElement<DXW.AlignTablesRowByRow>
{
  public AlignTablesRowByRow(): base(){ }
  
  public AlignTablesRowByRow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlignTablesRowByRow(DXW.AlignTablesRowByRow openXmlElement): base(openXmlElement) { }
  
}
