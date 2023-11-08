namespace DocumentModel.Wordprocessing;


/// <summary>
///   Index of Column Containing Unique Values for Record.
/// </summary>
public partial class ColumnIndex: ModelElement<DXW.ColumnIndex>
{
  public ColumnIndex(): base(){ }
  
  public ColumnIndex(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColumnIndex(DXW.ColumnIndex openXmlElement): base(openXmlElement) { }
  
}
