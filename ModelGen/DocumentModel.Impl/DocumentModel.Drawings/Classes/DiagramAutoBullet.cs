namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DiagramAutoBullet Class.
/// </summary>
public class DiagramAutoBulletImpl: ModelElementImpl, DiagramAutoBullet
{
  public DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// prefix, this property is only available in Office 2019 and later.
  /// </summary>
  public String? AutoBulletPrefix
  {
    get;
    set;
  }
  
  /// <summary>
  /// leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  public Boolean? LeadZeros
  {
    get;
    set;
  }
  
  /// <summary>
  /// No Bullet.
  /// </summary>
  public Boolean? NoBullet
  {
    get;
    set;
  }
  
  /// <summary>
  /// Auto-Numbered Bullet.
  /// </summary>
  public AutoNumberedBullet? AutoNumberedBullet
  {
    get;
    set;
  }
  
  /// <summary>
  /// Character Bullet.
  /// </summary>
  public CharacterBullet? CharacterBullet
  {
    get;
    set;
  }
  
  /// <summary>
  /// Picture Bullet.
  /// </summary>
  public PictureBullet? PictureBullet
  {
    get;
    set;
  }
  
}
