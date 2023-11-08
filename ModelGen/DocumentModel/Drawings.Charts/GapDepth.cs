namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the GapDepth Class.
/// </summary>
public partial class GapDepth: ModelElement<DXDC.GapDepth>
{
  public GapDepth(): base(){ }
  
  public GapDepth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GapDepth(DXDC.GapDepth openXmlElement): base(openXmlElement) { }
  
}
