namespace DocumentModel.Drawing;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public interface IAutoNumberedBullet // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Bullet Autonumbering Type
  /// </summary>
  public DocumentModel.Drawing.TextAutoNumberSchemeKind? Type { get ; set; }
  
  /// <summary>
  /// Start Numbering At
  /// </summary>
  public System.Int32? StartAt { get ; set; }
  
}
