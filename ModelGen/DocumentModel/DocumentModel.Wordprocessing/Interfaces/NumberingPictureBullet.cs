namespace DocumentModel.Wordprocessing;

/// <summary>
/// Picture Numbering Symbol Definition.
/// </summary>
public interface NumberingPictureBullet
{
  /// <summary>
  /// PictureBulletBase.
  /// </summary>
  public PictureBulletBase? PictureBulletBase { get ; set; }
  
  /// <summary>
  /// Drawing.
  /// </summary>
  public Drawing? Drawing { get ; set; }
  
}
