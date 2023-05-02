namespace DocumentModel.Drawings.Diagram1;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DiagramAutoBullet Class.
/// </summary>
public class DiagramAutoBullet: ModelElement
{
  /// <summary>
  ///   prefix, this property is only available in Office 2019 and later.
  /// </summary>
  public string? AutoBulletPrefix { get; set; }

  /// <summary>
  ///   leadZeros, this property is only available in Office 2019 and later.
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