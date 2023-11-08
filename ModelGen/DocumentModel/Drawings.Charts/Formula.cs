namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Formula Class.
/// </summary>
public partial class Formula: ModelElement<DXDC.Formula>
{
  public Formula(): base(){ }
  
  public Formula(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Formula(DXDC.Formula openXmlElement): base(openXmlElement) { }
  
}
