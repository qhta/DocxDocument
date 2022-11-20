namespace DocumentModel.Drawing;

/// <summary>
/// Picture Bullet.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlip))]
public class PictureBullet: IPictureBullet
{
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Drawing.IBlip? Blip
  {
    get;
    set;
  }
  
}
