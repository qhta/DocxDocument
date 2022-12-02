namespace DocumentModel.Drawing;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public interface IAutoNumberedBullet // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Bullet Autonumbering Type
  /// </summary>
  public TextAutoNumberSchemeKind? Type { get ; set; }
  
  /// <summary>
  /// Start Numbering At
  /// </summary>
  public Int32? StartAt { get ; set; }
  
}
