namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Split Position.
/// </summary>
public partial class SplitPosition: ModelElement<DXDC.SplitPosition>
{
  public SplitPosition(): base(){ }
  
  public SplitPosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SplitPosition(DXDC.SplitPosition openXmlElement): base(openXmlElement) { }
  
}
