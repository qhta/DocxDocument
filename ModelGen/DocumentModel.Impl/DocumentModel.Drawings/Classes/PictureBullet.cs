namespace DocumentModel.Drawings;

/// <summary>
/// Picture Bullet.
/// </summary>
public class PictureBulletImpl: ModelElement<DocumentFormat.OpenXml.Drawing.PictureBullet>, PictureBullet
{
  /// <summary>
  /// Blip.
  /// </summary>
  public Blip? Blip
  {
    get;
    set;
  }
  
}
