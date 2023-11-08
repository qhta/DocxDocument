namespace DocumentModel.Word10;


/// <summary>
///   This element contains a list of gradient stops. These gradient stops specify the gradient colors and their relative positions in the color band.
/// </summary>
public partial class GradientStopList: ModelElement<DXO10W.GradientStopList>
{
  public GradientStopList(): base(){ }
  
  public GradientStopList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientStopList(DXO10W.GradientStopList openXmlElement): base(openXmlElement) { }
  
}
