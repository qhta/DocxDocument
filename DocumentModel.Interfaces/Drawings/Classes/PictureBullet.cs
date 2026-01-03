namespace DocumentModel.Drawings;

/// <summary>
///   Picture Bullet.
/// </summary>
public interface PictureBullet: IModelElement
{
  /// <summary>
  ///   Blip.
  /// </summary>
  public Blip? Blip { get; set; }
}