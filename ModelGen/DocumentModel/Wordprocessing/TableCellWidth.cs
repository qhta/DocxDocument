namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the preferred width for this table cell. This preferred width is used as part of the table layout algorithm specified by the tblLayout element.
/// </summary>
public partial class TableCellWidth: ModelElement<DXW.TableCellWidth>
{
  public TableCellWidth(): base(){ }
  
  public TableCellWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellWidth(DXW.TableCellWidth openXmlElement): base(openXmlElement) { }
  
}
