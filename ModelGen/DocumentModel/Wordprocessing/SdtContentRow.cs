namespace DocumentModel.Wordprocessing;


/// <summary>
///   Row-Level Structured Document Tag Content.
/// </summary>
public partial class SdtContentRow: ModelElement<DXW.SdtContentRow>
{
  public SdtContentRow(): base(){ }
  
  public SdtContentRow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentRow(DXW.SdtContentRow openXmlElement): base(openXmlElement) { }
  
}
