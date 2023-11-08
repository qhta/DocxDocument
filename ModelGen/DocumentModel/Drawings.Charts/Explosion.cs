namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Explosion.
/// </summary>
public partial class Explosion: ModelElement<DXDC.Explosion>
{
  public Explosion(): base(){ }
  
  public Explosion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Explosion(DXDC.Explosion openXmlElement): base(openXmlElement) { }
  
}
