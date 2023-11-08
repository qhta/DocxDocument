namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that the output color rendered by the generating application should be the sRGB gamma shift of the input color.
/// </summary>
public partial class Gamma: ModelElement<DXD.Gamma>
{
  public Gamma(): base(){ }
  
  public Gamma(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Gamma(DXD.Gamma openXmlElement): base(openXmlElement) { }
  
}
