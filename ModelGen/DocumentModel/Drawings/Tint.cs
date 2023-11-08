namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a lighter version of its input color. A 10% tint is 10% of the input color combined with 90% white.
/// </summary>
public partial class Tint: ModelElement<DXD.Tint>
{
  public Tint(): base(){ }
  
  public Tint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Tint(DXD.Tint openXmlElement): base(openXmlElement) { }
  
}
