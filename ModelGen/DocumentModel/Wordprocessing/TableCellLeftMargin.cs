namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed on the left side of the page around the specified paragraph. This shall not change based on the paragraph direction.
/// </summary>
public partial class TableCellLeftMargin: ModelElement<DXW.TableCellLeftMargin>
{
  public TableCellLeftMargin(): base(){ }
  
  public TableCellLeftMargin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellLeftMargin(DXW.TableCellLeftMargin openXmlElement): base(openXmlElement) { }
  
}
