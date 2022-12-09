namespace DocumentModel.Drawings;

/// <summary>
/// Text Paragraph Properties.
/// </summary>
public interface ParagraphProperties
{
  public LineSpacing? LineSpacing { get ; set; }
  
  public SpaceBefore? SpaceBefore { get ; set; }
  
  public SpaceAfter? SpaceAfter { get ; set; }
  
  public Boolean? BulletColorText { get ; set; }
  
  public BulletColor? BulletColor { get ; set; }
  
  public Boolean? BulletSizeText { get ; set; }
  
  public Int32? BulletSizePercentage { get ; set; }
  
  public Int32? BulletSizePoints { get ; set; }
  
  public Boolean? BulletFontText { get ; set; }
  
  public TextFontType? BulletFont { get ; set; }
  
  public Boolean? NoBullet { get ; set; }
  
  public AutoNumberedBullet? AutoNumberedBullet { get ; set; }
  
  public CharacterBullet? CharacterBullet { get ; set; }
  
  public PictureBullet? PictureBullet { get ; set; }
  
  public TabStopList? TabStopList { get ; set; }
  
  public DefaultRunProperties? DefaultRunProperties { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
