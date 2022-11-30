namespace DocumentModel.Drawing;

/// <summary>
/// List Level 7 Text Style.
/// </summary>
public interface ILevel7ParagraphProperties // : DocumentModel.Drawing.ITextParagraphPropertiesType
{
  public DocumentModel.Drawing.ILineSpacing? LineSpacing { get ; set; }
  
  public DocumentModel.Drawing.ISpaceBefore? SpaceBefore { get ; set; }
  
  public DocumentModel.Drawing.ISpaceAfter? SpaceAfter { get ; set; }
  
  public System.Boolean? BulletColorText { get ; set; }
  
  public DocumentModel.Drawing.IBulletColor? BulletColor { get ; set; }
  
  public System.Boolean? BulletSizeText { get ; set; }
  
  public System.Int32? BulletSizePercentage { get ; set; }
  
  public System.Int32? BulletSizePoints { get ; set; }
  
  public System.Boolean? BulletFontText { get ; set; }
  
  public DocumentModel.Drawing.ITextFontType? BulletFont { get ; set; }
  
  public System.Boolean? NoBullet { get ; set; }
  
  public DocumentModel.Drawing.IAutoNumberedBullet? AutoNumberedBullet { get ; set; }
  
  public DocumentModel.Drawing.ICharacterBullet? CharacterBullet { get ; set; }
  
  public DocumentModel.Drawing.IPictureBullet? PictureBullet { get ; set; }
  
  public DocumentModel.Drawing.ITabStopList? TabStopList { get ; set; }
  
  public DocumentModel.Drawing.IDefaultRunProperties? DefaultRunProperties { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
