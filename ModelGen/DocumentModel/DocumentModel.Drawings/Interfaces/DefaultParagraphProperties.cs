namespace DocumentModel.Drawings;

/// <summary>
/// Default Paragraph Style.
/// </summary>
public interface DefaultParagraphProperties
{
  public LineSpacing? LineSpacing { get ; set; }
  
  public SpaceBefore? SpaceBefore { get ; set; }
  
  public SpaceAfter? SpaceAfter { get ; set; }
  
  public BulletColor? BulletColor { get ; set; }
  
  public Boolean? BulletFont { get ; set; }
  
  public AutoNumberedBullet? AutoNumberedBullet { get ; set; }
  
  public CharacterBullet? CharacterBullet { get ; set; }
  
  public PictureBullet? PictureBullet { get ; set; }
  
  public TabStopList? TabStopList { get ; set; }
  
  public DefaultRunProperties? DefaultRunProperties { get ; set; }
  
  public ExtensionList1? ExtensionList { get ; set; }
  
}
