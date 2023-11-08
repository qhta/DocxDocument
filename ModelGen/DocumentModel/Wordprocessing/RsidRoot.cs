namespace DocumentModel.Wordprocessing;


/// <summary>
///   Original Document Revision Save ID.
/// </summary>
public partial class RsidRoot: ModelElement<DXW.RsidRoot>
{
  public RsidRoot(): base(){ }
  
  public RsidRoot(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RsidRoot(DXW.RsidRoot openXmlElement): base(openXmlElement) { }
  
}
