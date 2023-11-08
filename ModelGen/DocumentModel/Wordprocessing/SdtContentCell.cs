namespace DocumentModel.Wordprocessing;


/// <summary>
///   Cell-Level Structured Document Tag Content.
/// </summary>
public partial class SdtContentCell: ModelElement<DXW.SdtContentCell>
{
  public SdtContentCell(): base(){ }
  
  public SdtContentCell(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentCell(DXW.SdtContentCell openXmlElement): base(openXmlElement) { }
  
}
