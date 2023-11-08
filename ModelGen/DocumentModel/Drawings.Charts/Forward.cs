namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Forward.
/// </summary>
public partial class Forward: ModelElement<DXDC.Forward>
{
  public Forward(): base(){ }
  
  public Forward(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Forward(DXDC.Forward openXmlElement): base(openXmlElement) { }
  
}
