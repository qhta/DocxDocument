namespace DocumentModel.Drawing;

/// <summary>
/// List Level 3 Text Style.
/// </summary>
public interface ILevel3ParagraphProperties // : DocumentModel.Drawing.ITextParagraphPropertiesType
{
  public ILineSpacing? LineSpacing { get ; set; }
  
  public ISpaceBefore? SpaceBefore { get ; set; }
  
  public ISpaceAfter? SpaceAfter { get ; set; }
  
  public Boolean? BulletColorText { get ; set; }
  
  public IBulletColor? BulletColor { get ; set; }
  
  public Boolean? BulletSizeText { get ; set; }
  
  public Int32? BulletSizePercentage { get ; set; }
  
  public Int32? BulletSizePoints { get ; set; }
  
  public Boolean? BulletFontText { get ; set; }
  
  public ITextFontType? BulletFont { get ; set; }
  
  public Boolean? NoBullet { get ; set; }
  
  public IAutoNumberedBullet? AutoNumberedBullet { get ; set; }
  
  public ICharacterBullet? CharacterBullet { get ; set; }
  
  public IPictureBullet? PictureBullet { get ; set; }
  
  public ITabStopList? TabStopList { get ; set; }
  
  public IDefaultRunProperties? DefaultRunProperties { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
