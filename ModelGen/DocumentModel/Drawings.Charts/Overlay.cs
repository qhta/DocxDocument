namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Overlay.
/// </summary>
public partial class Overlay: ModelElement<DXDC.Overlay>
{
  public Overlay(): base(){ }
  
  public Overlay(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Overlay(DXDC.Overlay openXmlElement): base(openXmlElement) { }
  
}
