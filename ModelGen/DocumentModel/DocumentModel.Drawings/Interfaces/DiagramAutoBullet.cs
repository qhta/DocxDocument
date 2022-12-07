namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DiagramAutoBullet Class.
/// </summary>
public interface DiagramAutoBullet
{
  /// <summary>
  /// Auto-Numbered Bullet.
  /// </summary>
  public AutoNumberedBullet? AutoNumberedBullet { get ; set; }
  
  /// <summary>
  /// Character Bullet.
  /// </summary>
  public CharacterBullet? CharacterBullet { get ; set; }
  
  /// <summary>
  /// Picture Bullet.
  /// </summary>
  public PictureBullet? PictureBullet { get ; set; }
  
}
