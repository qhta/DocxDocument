namespace DocumentModel.Wordprocessing;


/// <summary>
///   Inline-Level Structured Document Tag Content.
/// </summary>
public partial class SdtContentRun: ModelElement<DXW.SdtContentRun>
{
  public SdtContentRun(): base(){ }
  
  public SdtContentRun(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentRun(DXW.SdtContentRun openXmlElement): base(openXmlElement) { }
  
}
