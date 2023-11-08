namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the number of rows which shall comprise each a table style row band for this table style. This element determines how many rows constitute each of the row bands for the current table, allowing row band formatting to be applied to groups of rows (rather than just single alternating rows) when the table is formatted.
/// </summary>
public partial class TableStyleRowBandSize: ModelElement<DXW.TableStyleRowBandSize>
{
  public TableStyleRowBandSize(): base(){ }
  
  public TableStyleRowBandSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableStyleRowBandSize(DXW.TableStyleRowBandSize openXmlElement): base(openXmlElement) { }
  
}
