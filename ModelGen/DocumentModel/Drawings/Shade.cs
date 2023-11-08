namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a darker version of its input color. A 10% shade is 10% of the input color combined with 90% black.
/// </summary>
public partial class Shade: ModelElement<DXD.Shade>
{
  public Shade(): base(){ }
  
  public Shade(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shade(DXD.Shade openXmlElement): base(openXmlElement) { }
  
}
