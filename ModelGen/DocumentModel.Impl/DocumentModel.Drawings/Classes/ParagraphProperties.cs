namespace DocumentModel.Drawings;

/// <summary>
/// Text Paragraph Properties.
/// </summary>
public class ParagraphPropertiesImpl: DocumentModel.Drawings.TextParagraphPropertiesTypeImpl, ParagraphProperties
{
  public override LineSpacing? LineSpacing
  {
    get;
    set;
  }
  
  public override SpaceBefore? SpaceBefore
  {
    get;
    set;
  }
  
  public override SpaceAfter? SpaceAfter
  {
    get;
    set;
  }
  
  public BulletColor? BulletColor
  {
    get;
    set;
  }
  
  public AutoNumberedBullet? AutoNumberedBullet
  {
    get;
    set;
  }
  
  public CharacterBullet? CharacterBullet
  {
    get;
    set;
  }
  
  public PictureBullet? PictureBullet
  {
    get;
    set;
  }
  
  public TabStopList? TabStopList
  {
    get;
    set;
  }
  
  public DefaultRunProperties? DefaultRunProperties
  {
    get;
    set;
  }
  
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
