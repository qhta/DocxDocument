namespace DocumentModel.Drawings;


/// <summary>
///   Bullet Size Follows Text.
/// </summary>
public partial class BulletSizeText: ModelElement<DXD.BulletSizeText>
{
  public BulletSizeText(): base(){ }
  
  public BulletSizeText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BulletSizeText(DXD.BulletSizeText openXmlElement): base(openXmlElement) { }
  
}
