namespace DocumentModel.Wordprocessing;


/// <summary>
///   Always Use Fixed Width for Hangul Characters.
/// </summary>
public partial class DisplayHangulFixedWidth: ModelElement<DXW.DisplayHangulFixedWidth>
{
  public DisplayHangulFixedWidth(): base(){ }
  
  public DisplayHangulFixedWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DisplayHangulFixedWidth(DXW.DisplayHangulFixedWidth openXmlElement): base(openXmlElement) { }
  
}
