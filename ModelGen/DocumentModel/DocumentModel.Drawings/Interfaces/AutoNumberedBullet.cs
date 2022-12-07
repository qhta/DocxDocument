namespace DocumentModel.Drawings;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public interface AutoNumberedBullet
{
  /// <summary>
  /// Bullet Autonumbering Type
  /// </summary>
  public TextAutoNumberSchemeKind? Type { get ; set; }
  
}
