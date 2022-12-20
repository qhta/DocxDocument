namespace DocumentModel.Drawings;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public partial interface AutoNumberedBullet
{
  /// <summary>
  /// Bullet Autonumbering Type
  /// </summary>
  public DocumentModel.Drawings.TextAutoNumberSchemeKind? Type { get; set; }
  
  /// <summary>
  /// Start Numbering At
  /// </summary>
  public Int32? StartAt { get; set; }
  
}
