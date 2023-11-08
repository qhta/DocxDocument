namespace DocumentModel.Wordprocessing;


/// <summary>
///   Header.
/// </summary>
public partial class Header: ModelElement<DXW.Header>
{
  public Header(): base(){ }
  
  public Header(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Header(DXW.Header openXmlElement): base(openXmlElement) { }
  
}
