namespace DocumentModel.Office2019.Drawing.Diagram11;

/// <summary>
/// Defines the DiagramAutoBullet Class.
/// </summary>
public interface IDiagramAutoBullet // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// prefix, this property is only available in Office 2019 and later.
  /// </summary>
  public System.String? AutoBulletPrefix { get ; set; }
  
  /// <summary>
  /// leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  public System.Boolean? LeadZeros { get ; set; }
  
  /// <summary>
  /// No Bullet.
  /// </summary>
  public System.Boolean? NoBullet { get ; set; }
  
  /// <summary>
  /// Auto-Numbered Bullet.
  /// </summary>
  public DocumentModel.Drawing.IAutoNumberedBullet? AutoNumberedBullet { get ; set; }
  
  /// <summary>
  /// Character Bullet.
  /// </summary>
  public DocumentModel.Drawing.ICharacterBullet? CharacterBullet { get ; set; }
  
  /// <summary>
  /// Picture Bullet.
  /// </summary>
  public DocumentModel.Drawing.IPictureBullet? PictureBullet { get ; set; }
  
}
