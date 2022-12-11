namespace DocumentModel.Drawings;

/// <summary>
/// Picture Bullet.
/// </summary>
public class PictureBulletImpl: ModelElementImpl, PictureBullet
{
  public DocumentFormat.OpenXml.Drawing.PictureBullet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PictureBullet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PictureBulletImpl(): base() {}
  
  public PictureBulletImpl(DocumentFormat.OpenXml.Drawing.PictureBullet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public Blip? Blip
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
