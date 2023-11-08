namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the AutoLabeled Class.
/// </summary>
public partial class AutoLabeled: ModelElement<DXDC.AutoLabeled>
{
  public AutoLabeled(): base(){ }
  
  public AutoLabeled(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutoLabeled(DXDC.AutoLabeled openXmlElement): base(openXmlElement) { }
  
}
