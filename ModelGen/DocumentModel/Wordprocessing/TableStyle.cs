namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the style ID of the table style which shall be used to format the contents of this table.
/// </summary>
public partial class TableStyle: ModelElement<DXW.TableStyle>
{
  public TableStyle(): base(){ }
  
  public TableStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableStyle(DXW.TableStyle openXmlElement): base(openXmlElement) { }
  
}
