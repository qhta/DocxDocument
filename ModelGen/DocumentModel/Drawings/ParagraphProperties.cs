namespace DocumentModel.Drawings;


/// <summary>
///   Text Paragraph Properties.
/// </summary>
public partial class ParagraphProperties: ModelElement<DXD.ParagraphProperties>
{
  public ParagraphProperties(): base(){ }
  
  public ParagraphProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphProperties(DXD.ParagraphProperties openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.LineSpacing? LineSpacing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LineSpacing>();
      if (element != null)
        return LineSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LineSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSpacingConverter.CreateOpenXmlElement<DXD.LineSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.SpaceBefore? SpaceBefore
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.SpaceBefore>();
      if (element != null)
        return SpaceBeforeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SpaceBefore>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpaceBeforeConverter.CreateOpenXmlElement<DXD.SpaceBefore>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.SpaceAfter? SpaceAfter
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.SpaceAfter>();
      if (element != null)
        return SpaceAfterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SpaceAfter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpaceAfterConverter.CreateOpenXmlElement<DXD.SpaceAfter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.BulletColorText? BulletColorText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BulletColorText>();
      if (element != null)
        return BulletColorTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BulletColorText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BulletColorTextConverter.CreateOpenXmlElement<DXD.BulletColorText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.BulletColor? BulletColor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BulletColor>();
      if (element != null)
        return BulletColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BulletColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BulletColorConverter.CreateOpenXmlElement<DXD.BulletColor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.BulletSizeText? BulletSizeText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BulletSizeText>();
      if (element != null)
        return BulletSizeTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BulletSizeText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BulletSizeTextConverter.CreateOpenXmlElement<DXD.BulletSizeText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXD.BulletSizePercentage,System.Int32>(openXmlElement, value);
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
      SimpleValueConverter.SetValue<DXD.BulletSizePoints,System.Int32>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMD.BulletFontText? BulletFontText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BulletFontText>();
      if (element != null)
        return BulletFontTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BulletFontText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BulletFontTextConverter.CreateOpenXmlElement<DXD.BulletFontText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.BulletFont? BulletFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BulletFont>();
      if (element != null)
        return BulletFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BulletFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BulletFontConverter.CreateOpenXmlElement<DXD.BulletFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.NoBullet? NoBullet
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.NoBullet>();
      if (element != null)
        return NoBulletConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NoBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoBulletConverter.CreateOpenXmlElement<DXD.NoBullet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.AutoNumberedBullet? AutoNumberedBullet
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.AutoNumberedBullet>();
      if (element != null)
        return AutoNumberedBulletConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.AutoNumberedBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoNumberedBulletConverter.CreateOpenXmlElement<DXD.AutoNumberedBullet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.CharacterBullet? CharacterBullet
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.CharacterBullet>();
      if (element != null)
        return CharacterBulletConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.CharacterBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CharacterBulletConverter.CreateOpenXmlElement<DXD.CharacterBullet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.PictureBullet? PictureBullet
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.PictureBullet>();
      if (element != null)
        return PictureBulletConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PictureBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureBulletConverter.CreateOpenXmlElement<DXD.PictureBullet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.TabStopList? TabStopList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.TabStopList>();
      if (element != null)
        return TabStopListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.TabStopList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TabStopListConverter.CreateOpenXmlElement<DXD.TabStopList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.DefaultRunProperties? DefaultRunProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.DefaultRunProperties>();
      if (element != null)
        return DefaultRunPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.DefaultRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DefaultRunPropertiesConverter.CreateOpenXmlElement<DXD.DefaultRunProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
