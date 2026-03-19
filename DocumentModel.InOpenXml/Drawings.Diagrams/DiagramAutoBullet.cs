namespace DocumentModel.Drawings.Diagram1;

/// <summary>
///   Defines the DiagramAutoBullet Class.
/// </summary>
[OpenXmlType(typeof(DXO19DD1.DiagramAutoBullet))]
/// <summary>
/// Represents the Diagram Auto Bullet.
/// </summary>
public class DiagramAutoBullet: ModelElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>
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
