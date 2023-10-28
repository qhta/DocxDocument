namespace DocumentModel.Drawings.Diagram1;


/// <summary>
///   Defines the DiagramAutoBullet Class.
/// </summary>
public partial class DiagramAutoBullet
{
  
  /// <summary>
  ///   prefix, this property is only available in Office 2019 and later.
  /// </summary>
  public String? AutoBulletPrefix { get; set; }
  
  
  /// <summary>
  ///   leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  public Boolean? LeadZeros { get; set; }
  
  
  /// <summary>
  ///   No Bullet.
  /// </summary>
  public DMD.NoBullet? NoBullet { get; set; }
  
  
  /// <summary>
  ///   Auto-Numbered Bullet.
  /// </summary>
  public DMD.AutoNumberedBullet? AutoNumberedBullet { get; set; }
  
  
  /// <summary>
  ///   Character Bullet.
  /// </summary>
  public DMD.CharacterBullet? CharacterBullet { get; set; }
  
  
  /// <summary>
  ///   Picture Bullet.
  /// </summary>
  public DMD.PictureBullet? PictureBullet { get; set; }
  
}
