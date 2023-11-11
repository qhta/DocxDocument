namespace DocumentModel.Drawings;


/// <summary>
///   Picture Bullet.
/// </summary>
public partial class PictureBullet: ModelElement<DXD.PictureBullet>
{
  public PictureBullet(): base(){ }
  
  public PictureBullet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PictureBullet(DXD.PictureBullet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Blip.
  /// </summary>
  [DataMember]
  public DMD.Blip? Blip
  {
    get
    {
      return _Element?.GetObject<DMD.Blip,DXD.Blip>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Blip,DXD.Blip>(value);
    }
  }
  
}
