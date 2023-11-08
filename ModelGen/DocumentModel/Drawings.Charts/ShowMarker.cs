namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ShowMarker Class.
/// </summary>
public partial class ShowMarker: ModelElement<DXDC.ShowMarker>
{
  public ShowMarker(): base(){ }
  
  public ShowMarker(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShowMarker(DXDC.ShowMarker openXmlElement): base(openXmlElement) { }
  
}
