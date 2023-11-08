namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Total Edit Time Metadata Element.
/// </summary>
public partial class TotalTime: ModelElement<DXEP.TotalTime>
{
  public TotalTime(): base(){ }
  
  public TotalTime(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TotalTime(DXEP.TotalTime openXmlElement): base(openXmlElement) { }
  
}
