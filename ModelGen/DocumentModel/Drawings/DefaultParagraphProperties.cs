namespace DocumentModel.Drawings;


/// <summary>
///   Default Paragraph Style.
/// </summary>
public partial class DefaultParagraphProperties
{
  public DMD.LineSpacing? LineSpacing { get; set; }
  
  public DMD.SpaceBefore? SpaceBefore { get; set; }
  
  public DMD.SpaceAfter? SpaceAfter { get; set; }
  
  public DMD.BulletColorText? BulletColorText { get; set; }
  
  public DMD.BulletColor? BulletColor { get; set; }
  
  public DMD.BulletSizeText? BulletSizeText { get; set; }
  
  public Int32? BulletSizePercentage { get; set; }
  
  public Int32? BulletSizePoints { get; set; }
  
  public DMD.BulletFontText? BulletFontText { get; set; }
  
  public DMD.BulletFont? BulletFont { get; set; }
  
  public DMD.NoBullet? NoBullet { get; set; }
  
  public DMD.AutoNumberedBullet? AutoNumberedBullet { get; set; }
  
  public DMD.CharacterBullet? CharacterBullet { get; set; }
  
  public DMD.PictureBullet? PictureBullet { get; set; }
  
  public DMD.TabStopList? TabStopList { get; set; }
  
  public DMD.DefaultRunProperties? DefaultRunProperties { get; set; }
  
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
