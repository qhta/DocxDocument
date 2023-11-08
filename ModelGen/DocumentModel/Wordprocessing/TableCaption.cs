namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the caption for the table.
/// </summary>
public partial class TableCaption: ModelElement<DXW.TableCaption>
{
  public TableCaption(): base(){ }
  
  public TableCaption(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCaption(DXW.TableCaption openXmlElement): base(openXmlElement) { }
  
}
