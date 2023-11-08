namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the number of columns which shall comprise each a table style column band for this table style. This element determines how many columns constitute each of the column bands for the current table, allowing column band formatting to be applied to groups of columns (rather than just single alternating columns) when the table is formatted.
/// </summary>
public partial class TableStyleColumnBandSize: ModelElement<DXW.TableStyleColumnBandSize>
{
  public TableStyleColumnBandSize(): base(){ }
  
  public TableStyleColumnBandSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableStyleColumnBandSize(DXW.TableStyleColumnBandSize openXmlElement): base(openXmlElement) { }
  
}
