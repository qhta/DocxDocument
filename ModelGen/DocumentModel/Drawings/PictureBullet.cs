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
      var element = _Element?.GetFirstChild<DXD.Blip>();
      if (element != null)
        return BlipConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Blip>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipConverter.CreateOpenXmlElement<DXD.Blip>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
