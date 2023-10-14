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
  public DocumentModel.Drawings.NoBullet? NoBullet { get; set; }
  
  
  /// <summary>
  ///   Auto-Numbered Bullet.
  /// </summary>
  public DocumentModel.Drawings.AutoNumberedBullet? AutoNumberedBullet { get; set; }
  
  
  /// <summary>
  ///   Character Bullet.
  /// </summary>
  public DocumentModel.Drawings.CharacterBullet? CharacterBullet { get; set; }
  
  
  /// <summary>
  ///   Picture Bullet.
  /// </summary>
  public DocumentModel.Drawings.PictureBullet? PictureBullet { get; set; }
  
}
