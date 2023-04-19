namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   List Level 9 Text Style.
/// </summary>
public class Level9ParagraphProperties: ModelElement
{
  public LineSpacing? LineSpacing { get; set; }

  public SpaceBefore? SpaceBefore { get; set; }

  public SpaceAfter? SpaceAfter { get; set; }

  public bool? BulletColorText { get; set; }

  public BulletColor? BulletColor { get; set; }

  public bool? BulletSizeText { get; set; }

  public Int32? BulletSizePercentage { get; set; }

  public Int32? BulletSizePoints { get; set; }

  public bool? BulletFontText { get; set; }

  public TextFontType? BulletFont { get; set; }

  public bool? NoBullet { get; set; }

  public AutoNumberedBullet? AutoNumberedBullet { get; set; }

  public CharacterBullet? CharacterBullet { get; set; }

  public PictureBullet? PictureBullet { get; set; }

  public TabStopList? TabStopList { get; set; }

  public DefaultRunProperties? DefaultRunProperties { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}