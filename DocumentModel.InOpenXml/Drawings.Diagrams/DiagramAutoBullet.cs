namespace DocumentModel.Drawings.Diagram1;

/// <summary>
///   Defines the DiagramAutoBullet Class.
/// </summary>
public class DiagramAutoBullet
{
  /// <summary>
  ///   prefix
  /// </summary>
  public string? AutoBulletPrefix { get; set; }
  /// <summary>
  ///   leadZeros
  /// </summary>
  public bool? LeadZeros { get; set; }
  /// <summary>
  ///   No Bullet.
  /// </summary>
  public bool? NoBullet { get; set; }
  /// <summary>
  ///   Auto-Numbered Bullet.
  /// </summary>
  public AutoNumberedBullet? AutoNumberedBullet { get; set; }
  /// <summary>
  ///   Character Bullet.
  /// </summary>
  public CharacterBullet? CharacterBullet { get; set; }
  /// <summary>
  ///   Picture Bullet.
  /// </summary>
  public PictureBullet? PictureBullet { get; set; }
}