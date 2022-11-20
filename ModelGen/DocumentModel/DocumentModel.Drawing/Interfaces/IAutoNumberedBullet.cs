namespace DocumentModel.Drawing;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public interface IAutoNumberedBullet // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Bullet Autonumbering Type
  /// </summary>
  public TextAutoNumberSchemeValues? Type { get ; set; }
  
  /// <summary>
  /// Start Numbering At
  /// </summary>
  public int? StartAt { get ; set; }
  
}
