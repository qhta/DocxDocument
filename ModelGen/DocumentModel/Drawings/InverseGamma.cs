namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that the output color rendered by the generating application should be the inverse sRGB gamma shift of the input color.
/// </summary>
public partial class InverseGamma: ModelElement<DXD.InverseGamma>
{
  public InverseGamma(): base(){ }
  
  public InverseGamma(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public InverseGamma(DXD.InverseGamma openXmlElement): base(openXmlElement) { }
  
}
