namespace DocumentModel.Office2019.Drawing.Diagram11;

/// <summary>
/// Defines the DiagramAutoBullet Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IAutoNumberedBullet))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPictureBullet))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ICharacterBullet))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoBullet))]
public interface IDiagramAutoBullet // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// prefix, this property is only available in Office 2019 and later.
  /// </summary>
  public string? AutoBulletPrefix { get ; set; }
  
  /// <summary>
  /// leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? LeadZeros { get ; set; }
  
  /// <summary>
  /// No Bullet.
  /// </summary>
  public INoBullet? NoBullet { get ; set; }
  
  /// <summary>
  /// Auto-Numbered Bullet.
  /// </summary>
  public IAutoNumberedBullet? AutoNumberedBullet { get ; set; }
  
  /// <summary>
  /// Character Bullet.
  /// </summary>
  public ICharacterBullet? CharacterBullet { get ; set; }
  
  /// <summary>
  /// Picture Bullet.
  /// </summary>
  public IPictureBullet? PictureBullet { get ; set; }
  
}
