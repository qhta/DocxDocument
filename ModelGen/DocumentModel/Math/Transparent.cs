namespace DocumentModel.Math;


/// <summary>
///   Transparent (Phantom).
/// </summary>
public partial class Transparent: ModelElement<DXM.Transparent>
{
  public Transparent(): base(){ }
  
  public Transparent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Transparent(DXM.Transparent openXmlElement): base(openXmlElement) { }
  
}
