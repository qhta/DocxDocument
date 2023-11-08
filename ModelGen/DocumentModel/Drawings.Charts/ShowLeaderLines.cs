namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Show Leader Lines.
/// </summary>
public partial class ShowLeaderLines: ModelElement<DXDC.ShowLeaderLines>
{
  public ShowLeaderLines(): base(){ }
  
  public ShowLeaderLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShowLeaderLines(DXDC.ShowLeaderLines openXmlElement): base(openXmlElement) { }
  
}
