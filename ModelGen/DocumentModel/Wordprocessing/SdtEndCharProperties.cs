namespace DocumentModel.Wordprocessing;


/// <summary>
///   Structured Document Tag End Character Properties.
/// </summary>
public partial class SdtEndCharProperties: ModelElement<DXW.SdtEndCharProperties>
{
  public SdtEndCharProperties(): base(){ }
  
  public SdtEndCharProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtEndCharProperties(DXW.SdtEndCharProperties openXmlElement): base(openXmlElement) { }
  
}
