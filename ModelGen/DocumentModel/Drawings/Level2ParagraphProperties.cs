namespace DocumentModel.Drawings;


/// <summary>
///   List Level 2 Text Style.
/// </summary>
public partial class Level2ParagraphProperties: ModelElement<DXD.Level2ParagraphProperties>
{
  public Level2ParagraphProperties(): base(){ }
  
  public Level2ParagraphProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Level2ParagraphProperties(DXD.Level2ParagraphProperties openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.LineSpacing? LineSpacing
  {
    get
    {
      return _Element?.GetObject<DMD.LineSpacing,DXD.LineSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LineSpacing,DXD.LineSpacing>(value);
    }
  }
  
  [DataMember]
  public DMD.SpaceBefore? SpaceBefore
  {
    get
    {
      return _Element?.GetObject<DMD.SpaceBefore,DXD.SpaceBefore>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SpaceBefore,DXD.SpaceBefore>(value);
    }
  }
  
  [DataMember]
  public DMD.SpaceAfter? SpaceAfter
  {
    get
    {
      return _Element?.GetObject<DMD.SpaceAfter,DXD.SpaceAfter>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SpaceAfter,DXD.SpaceAfter>(value);
    }
  }
  
  [DataMember]
  public DMD.BulletColorText? BulletColorText
  {
    get
    {
      return _Element?.GetObject<DMD.BulletColorText,DXD.BulletColorText>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BulletColorText,DXD.BulletColorText>(value);
    }
  }
  
  [DataMember]
  public DMD.BulletColor? BulletColor
  {
    get
    {
      return _Element?.GetObject<DMD.BulletColor,DXD.BulletColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BulletColor,DXD.BulletColor>(value);
    }
  }
  
  [DataMember]
  public DMD.BulletSizeText? BulletSizeText
  {
    get
    {
      return _Element?.GetObject<DMD.BulletSizeText,DXD.BulletSizeText>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BulletSizeText,DXD.BulletSizeText>(value);
    }
  }
  
  [DataMember]
  public Int32? BulletSizePercentage
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXD.BulletSizePercentage>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXD.BulletSizePercentage,System.Int32>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public Int32? BulletSizePoints
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXD.BulletSizePoints>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXD.BulletSizePoints,System.Int32>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public DMD.BulletFontText? BulletFontText
  {
    get
    {
      return _Element?.GetObject<DMD.BulletFontText,DXD.BulletFontText>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BulletFontText,DXD.BulletFontText>(value);
    }
  }
  
  [DataMember]
  public DMD.BulletFont? BulletFont
  {
    get
    {
      return _Element?.GetObject<DMD.BulletFont,DXD.BulletFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BulletFont,DXD.BulletFont>(value);
    }
  }
  
  [DataMember]
  public DMD.NoBullet? NoBullet
  {
    get
    {
      return _Element?.GetObject<DMD.NoBullet,DXD.NoBullet>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NoBullet,DXD.NoBullet>(value);
    }
  }
  
  [DataMember]
  public DMD.AutoNumberedBullet? AutoNumberedBullet
  {
    get
    {
      return _Element?.GetObject<DMD.AutoNumberedBullet,DXD.AutoNumberedBullet>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.AutoNumberedBullet,DXD.AutoNumberedBullet>(value);
    }
  }
  
  [DataMember]
  public DMD.CharacterBullet? CharacterBullet
  {
    get
    {
      return _Element?.GetObject<DMD.CharacterBullet,DXD.CharacterBullet>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.CharacterBullet,DXD.CharacterBullet>(value);
    }
  }
  
  [DataMember]
  public DMD.PictureBullet? PictureBullet
  {
    get
    {
      return _Element?.GetObject<DMD.PictureBullet,DXD.PictureBullet>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PictureBullet,DXD.PictureBullet>(value);
    }
  }
  
  [DataMember]
  public DMD.TabStopList? TabStopList
  {
    get
    {
      return _Element?.GetObject<DMD.TabStopList,DXD.TabStopList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.TabStopList,DXD.TabStopList>(value);
    }
  }
  
  [DataMember]
  public DMD.DefaultRunProperties? DefaultRunProperties
  {
    get
    {
      return _Element?.GetObject<DMD.DefaultRunProperties,DXD.DefaultRunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.DefaultRunProperties,DXD.DefaultRunProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
