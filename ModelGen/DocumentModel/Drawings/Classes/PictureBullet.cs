namespace DocumentModel.Drawings;


/// <summary>
///   Picture Bullet.
/// </summary>
public partial class PictureBullet
{
  
  /// <summary>
  ///   Blip.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Drawings.Blip? Blip { get; set; }
  
}
