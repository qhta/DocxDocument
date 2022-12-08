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
  
  /// <summary>
  /// Blip.
  /// </summary>
  public Blip? Blip
  {
    get;
    set;
  }
  
}
