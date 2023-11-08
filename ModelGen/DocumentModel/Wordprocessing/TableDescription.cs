namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the description for the table.
/// </summary>
public partial class TableDescription: ModelElement<DXW.TableDescription>
{
  public TableDescription(): base(){ }
  
  public TableDescription(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableDescription(DXW.TableDescription openXmlElement): base(openXmlElement) { }
  
}
