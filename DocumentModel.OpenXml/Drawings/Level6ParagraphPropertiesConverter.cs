namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List Level 6 Text Style.
/// </summary>
public static class Level6ParagraphPropertiesConverter
{
  private static DMDraws.LineSpacing? GetLineSpacing(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LineSpacing>();
    if (itemElement != null)
      return DMXDraws.LineSpacingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineSpacing(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.LineSpacing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LineSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineSpacingConverter.CreateOpenXmlElement<DXDraw.LineSpacing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.SpaceBefore? GetSpaceBefore(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SpaceBefore>();
    if (itemElement != null)
      return DMXDraws.SpaceBeforeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSpaceBefore(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.SpaceBefore? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SpaceBefore>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SpaceBeforeConverter.CreateOpenXmlElement<DXDraw.SpaceBefore>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.SpaceAfter? GetSpaceAfter(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SpaceAfter>();
    if (itemElement != null)
      return DMXDraws.SpaceAfterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSpaceAfter(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.SpaceAfter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SpaceAfter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SpaceAfterConverter.CreateOpenXmlElement<DXDraw.SpaceAfter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBulletColorText(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BulletColorText>();
    return itemElement != null;
  }
  
  private static void SetBulletColorText(DXDraw.Level6ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.BulletColorText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.BulletColorText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BulletColor? GetBulletColor(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BulletColor>();
    if (itemElement != null)
      return DMXDraws.BulletColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBulletColor(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.BulletColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BulletColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BulletColorConverter.CreateOpenXmlElement<DXDraw.BulletColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBulletSizeText(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BulletSizeText>();
    return itemElement != null;
  }
  
  private static void SetBulletSizeText(DXDraw.Level6ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.BulletSizeText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.BulletSizeText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBulletSizePercentage(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BulletSizePercentage>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBulletSizePercentage(DXDraw.Level6ParagraphProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BulletSizePercentage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.BulletSizePercentage{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBulletSizePoints(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BulletSizePoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBulletSizePoints(DXDraw.Level6ParagraphProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BulletSizePoints>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.BulletSizePoints{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBulletFontText(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BulletFontText>();
    return itemElement != null;
  }
  
  private static void SetBulletFontText(DXDraw.Level6ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.BulletFontText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.BulletFontText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetBulletFont(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BulletFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBulletFont(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BulletFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.BulletFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoBullet(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.NoBullet>();
    return itemElement != null;
  }
  
  private static void SetNoBullet(DXDraw.Level6ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.NoBullet>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.NoBullet();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AutoNumberedBullet? GetAutoNumberedBullet(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AutoNumberedBullet>();
    if (itemElement != null)
      return DMXDraws.AutoNumberedBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAutoNumberedBullet(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.AutoNumberedBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AutoNumberedBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AutoNumberedBulletConverter.CreateOpenXmlElement<DXDraw.AutoNumberedBullet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.CharacterBullet? GetCharacterBullet(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.CharacterBullet>();
    if (itemElement != null)
      return DMXDraws.CharacterBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCharacterBullet(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.CharacterBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.CharacterBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CharacterBulletConverter.CreateOpenXmlElement<DXDraw.CharacterBullet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PictureBullet? GetPictureBullet(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PictureBullet>();
    if (itemElement != null)
      return DMXDraws.PictureBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureBullet(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.PictureBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PictureBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PictureBulletConverter.CreateOpenXmlElement<DXDraw.PictureBullet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TabStopList? GetTabStopList(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.TabStopList>();
    if (itemElement != null)
      return DMXDraws.TabStopListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTabStopList(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.TabStopList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.TabStopList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TabStopListConverter.CreateOpenXmlElement<DXDraw.TabStopList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.DefaultRunProperties? GetDefaultRunProperties(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.DefaultRunProperties>();
    if (itemElement != null)
      return DMXDraws.DefaultRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDefaultRunProperties(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.DefaultRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.DefaultRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.DefaultRunPropertiesConverter.CreateOpenXmlElement<DXDraw.DefaultRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.Level6ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.Level6ParagraphProperties openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.Level6ParagraphProperties? CreateModelElement(DXDraw.Level6ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Level6ParagraphProperties();
      value.LineSpacing = GetLineSpacing(openXmlElement);
      value.SpaceBefore = GetSpaceBefore(openXmlElement);
      value.SpaceAfter = GetSpaceAfter(openXmlElement);
      value.BulletColorText = GetBulletColorText(openXmlElement);
      value.BulletColor = GetBulletColor(openXmlElement);
      value.BulletSizeText = GetBulletSizeText(openXmlElement);
      value.BulletSizePercentage = GetBulletSizePercentage(openXmlElement);
      value.BulletSizePoints = GetBulletSizePoints(openXmlElement);
      value.BulletFontText = GetBulletFontText(openXmlElement);
      value.BulletFont = GetBulletFont(openXmlElement);
      value.NoBullet = GetNoBullet(openXmlElement);
      value.AutoNumberedBullet = GetAutoNumberedBullet(openXmlElement);
      value.CharacterBullet = GetCharacterBullet(openXmlElement);
      value.PictureBullet = GetPictureBullet(openXmlElement);
      value.TabStopList = GetTabStopList(openXmlElement);
      value.DefaultRunProperties = GetDefaultRunProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Level6ParagraphProperties? value)
    where OpenXmlElementType: DXDraw.Level6ParagraphProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineSpacing(openXmlElement, value?.LineSpacing);
      SetSpaceBefore(openXmlElement, value?.SpaceBefore);
      SetSpaceAfter(openXmlElement, value?.SpaceAfter);
      SetBulletColorText(openXmlElement, value?.BulletColorText);
      SetBulletColor(openXmlElement, value?.BulletColor);
      SetBulletSizeText(openXmlElement, value?.BulletSizeText);
      SetBulletSizePercentage(openXmlElement, value?.BulletSizePercentage);
      SetBulletSizePoints(openXmlElement, value?.BulletSizePoints);
      SetBulletFontText(openXmlElement, value?.BulletFontText);
      SetBulletFont(openXmlElement, value?.BulletFont);
      SetNoBullet(openXmlElement, value?.NoBullet);
      SetAutoNumberedBullet(openXmlElement, value?.AutoNumberedBullet);
      SetCharacterBullet(openXmlElement, value?.CharacterBullet);
      SetPictureBullet(openXmlElement, value?.PictureBullet);
      SetTabStopList(openXmlElement, value?.TabStopList);
      SetDefaultRunProperties(openXmlElement, value?.DefaultRunProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
