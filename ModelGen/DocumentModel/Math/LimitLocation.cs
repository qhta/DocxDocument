namespace DocumentModel.Math;


/// <summary>
///   n-ary Limit Location.
/// </summary>
public partial class LimitLocation: ModelElement<DXM.LimitLocation>
{
  public LimitLocation(): base(){ }
  
  public LimitLocation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitLocation(DXM.LimitLocation openXmlElement): base(openXmlElement) { }
  
}
