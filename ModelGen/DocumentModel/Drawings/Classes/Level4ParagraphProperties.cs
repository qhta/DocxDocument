namespace DocumentModel.Drawings;


/// <summary>
///   List Level 4 Text Style.
/// </summary>
public partial class Level4ParagraphProperties
{
  public DocumentModel.Drawings.LineSpacing? LineSpacing { get; set; }
  
  public DocumentModel.Drawings.SpaceBefore? SpaceBefore { get; set; }
  
  public DocumentModel.Drawings.SpaceAfter? SpaceAfter { get; set; }
  
  public Boolean? BulletColorText { get; set; }
  
  public DocumentModel.Drawings.BulletColor? BulletColor { get; set; }
  
  public Boolean? BulletSizeText { get; set; }
  
  public Int32? BulletSizePercentage { get; set; }
  
  public Int32? BulletSizePoints { get; set; }
  
  public Boolean? BulletFontText { get; set; }
  
  public DocumentModel.Drawings.TextFontType? BulletFont { get; set; }
  
  public Boolean? NoBullet { get; set; }
  
  public DocumentModel.Drawings.AutoNumberedBullet? AutoNumberedBullet { get; set; }
  
  public DocumentModel.Drawings.CharacterBullet? CharacterBullet { get; set; }
  
  public DocumentModel.Drawings.PictureBullet? PictureBullet { get; set; }
  
  public DocumentModel.Drawings.TabStopList? TabStopList { get; set; }
  
  public DocumentModel.Drawings.DefaultRunProperties? DefaultRunProperties { get; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
