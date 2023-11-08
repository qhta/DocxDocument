namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies how this table cell shall be laid out when the parent table is displayed in a document. This setting only affects the behavior of the cell when the tblLayout for this row.
/// </summary>
public partial class NoWrap: ModelElement<DXW.NoWrap>
{
  public NoWrap(): base(){ }
  
  public NoWrap(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoWrap(DXW.NoWrap openXmlElement): base(openXmlElement) { }
  
}
