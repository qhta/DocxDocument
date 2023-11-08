namespace DocumentModel.Wordprocessing;


/// <summary>
///   Underline Following Character Following Numbering.
/// </summary>
public partial class UnderlineTabInNumberingList: ModelElement<DXW.UnderlineTabInNumberingList>
{
  public UnderlineTabInNumberingList(): base(){ }
  
  public UnderlineTabInNumberingList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UnderlineTabInNumberingList(DXW.UnderlineTabInNumberingList openXmlElement): base(openXmlElement) { }
  
}
