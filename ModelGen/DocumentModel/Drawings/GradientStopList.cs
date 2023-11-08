namespace DocumentModel.Drawings;


/// <summary>
///   The list of gradient stops that specifies the gradient colors and their relative positions in the color band.
/// </summary>
public partial class GradientStopList: ModelElement<DXD.GradientStopList>
{
  public GradientStopList(): base(){ }
  
  public GradientStopList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientStopList(DXD.GradientStopList openXmlElement): base(openXmlElement) { }
  
}
