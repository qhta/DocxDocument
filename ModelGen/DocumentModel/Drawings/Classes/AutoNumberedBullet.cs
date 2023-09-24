namespace DocumentModel.Drawings;


/// <summary>
///   Auto-Numbered Bullet.
/// </summary>
public partial class AutoNumberedBullet
{
  
  /// <summary>
  ///   Bullet Autonumbering Type
  /// </summary>
  public TextAutoNumberSchemeKind? Type { get; set; }
  
  
  /// <summary>
  ///   Start Numbering At
  /// </summary>
  public Int32? StartAt { get; set; }
  
}
