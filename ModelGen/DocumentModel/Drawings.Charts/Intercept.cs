namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Intercept.
/// </summary>
public partial class Intercept: ModelElement<DXDC.Intercept>
{
  public Intercept(): base(){ }
  
  public Intercept(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Intercept(DXDC.Intercept openXmlElement): base(openXmlElement) { }
  
}
