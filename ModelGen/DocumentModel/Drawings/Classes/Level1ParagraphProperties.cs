namespace DocumentModel.Drawings;


/// <summary>
///   List Level 1 Text Style.
/// </summary>
public partial class Level1ParagraphProperties
{
  public DocumentModel.Drawings.LineSpacing? LineSpacing { get; set; }
  
  public DocumentModel.Drawings.SpaceBefore? SpaceBefore { get; set; }
  
  public DocumentModel.Drawings.SpaceAfter? SpaceAfter { get; set; }
  
  public DocumentModel.Drawings.BulletColorText? BulletColorText { get; set; }
  
  public DocumentModel.Drawings.BulletColor? BulletColor { get; set; }
  
  public DocumentModel.Drawings.BulletSizeText? BulletSizeText { get; set; }
  
  public Int32? BulletSizePercentage { get; set; }
  
  public Int32? BulletSizePoints { get; set; }
  
  public DocumentModel.Drawings.BulletFontText? BulletFontText { get; set; }
  
  public DocumentModel.Drawings.BulletFont? BulletFont { get; set; }
  
  public DocumentModel.Drawings.NoBullet? NoBullet { get; set; }
  
  public DocumentModel.Drawings.AutoNumberedBullet? AutoNumberedBullet { get; set; }
  
  public DocumentModel.Drawings.CharacterBullet? CharacterBullet { get; set; }
  
  public DocumentModel.Drawings.PictureBullet? PictureBullet { get; set; }
  
  public DocumentModel.Drawings.TabStopList? TabStopList { get; set; }
  
  public DocumentModel.Drawings.DefaultRunProperties? DefaultRunProperties { get; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
