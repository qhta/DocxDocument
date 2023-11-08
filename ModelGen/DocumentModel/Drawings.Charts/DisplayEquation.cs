namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Display Equation.
/// </summary>
public partial class DisplayEquation: ModelElement<DXDC.DisplayEquation>
{
  public DisplayEquation(): base(){ }
  
  public DisplayEquation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DisplayEquation(DXDC.DisplayEquation openXmlElement): base(openXmlElement) { }
  
}
