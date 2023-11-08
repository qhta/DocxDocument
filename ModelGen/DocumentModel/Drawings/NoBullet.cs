namespace DocumentModel.Drawings;


/// <summary>
///   No Bullet.
/// </summary>
public partial class NoBullet: ModelElement<DXD.NoBullet>
{
  public NoBullet(): base(){ }
  
  public NoBullet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoBullet(DXD.NoBullet openXmlElement): base(openXmlElement) { }
  
}
