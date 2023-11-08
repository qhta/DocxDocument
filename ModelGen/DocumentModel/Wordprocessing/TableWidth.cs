namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the preferred width for this table. This preferred width is used as part of the table layout algorithm specified by the tblLayout element.
/// </summary>
public partial class TableWidth: ModelElement<DXW.TableWidth>
{
  public TableWidth(): base(){ }
  
  public TableWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableWidth(DXW.TableWidth openXmlElement): base(openXmlElement) { }
  
}
