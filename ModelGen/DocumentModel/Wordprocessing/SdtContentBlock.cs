namespace DocumentModel.Wordprocessing;


/// <summary>
///   Block-Level Structured Document Tag Content.
/// </summary>
public partial class SdtContentBlock: ModelElement<DXW.SdtContentBlock>
{
  public SdtContentBlock(): base(){ }
  
  public SdtContentBlock(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentBlock(DXW.SdtContentBlock openXmlElement): base(openXmlElement) { }
  
}
