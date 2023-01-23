namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List Level 7 Text Style.
/// </summary>
public static class Level7ParagraphPropertiesConverter
{
  private static DMDraws.LineSpacing? GetLineSpacing(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.LineSpacingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.LineSpacing>());
  }
  
  private static bool CmpLineSpacing(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.LineSpacing? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineSpacingConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.LineSpacing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineSpacing(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.LineSpacing? value)
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
  
  private static DMDraws.SpaceBefore? GetSpaceBefore(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.SpaceBeforeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SpaceBefore>());
  }
  
  private static bool CmpSpaceBefore(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.SpaceBefore? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SpaceBeforeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SpaceBefore>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSpaceBefore(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.SpaceBefore? value)
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
  
  private static DMDraws.SpaceAfter? GetSpaceAfter(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.SpaceAfterConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SpaceAfter>());
  }
  
  private static bool CmpSpaceAfter(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.SpaceAfter? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SpaceAfterConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SpaceAfter>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSpaceAfter(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.SpaceAfter? value)
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
  
  private static Boolean? GetBulletColorText(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.BulletColorText>() != null;
  }
  
  private static bool CmpBulletColorText(DXDraw.Level7ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.BulletColorText>() != null == value;
  }
  
  private static void SetBulletColorText(DXDraw.Level7ParagraphProperties openXmlElement, Boolean? value)
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
  
  private static DMDraws.BulletColor? GetBulletColor(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.BulletColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.BulletColor>());
  }
  
  private static bool CmpBulletColor(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.BulletColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BulletColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.BulletColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBulletColor(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.BulletColor? value)
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
  
  private static Boolean? GetBulletSizeText(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.BulletSizeText>() != null;
  }
  
  private static bool CmpBulletSizeText(DXDraw.Level7ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.BulletSizeText>() != null == value;
  }
  
  private static void SetBulletSizeText(DXDraw.Level7ParagraphProperties openXmlElement, Boolean? value)
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
  
  private static Int32? GetBulletSizePercentage(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BulletSizePercentage>()?.Val?.Value;
  }
  
  private static bool CmpBulletSizePercentage(DXDraw.Level7ParagraphProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BulletSizePercentage>()?.Val?.Value == value;
  }
  
  private static void SetBulletSizePercentage(DXDraw.Level7ParagraphProperties openXmlElement, Int32? value)
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
  
  private static Int32? GetBulletSizePoints(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BulletSizePoints>()?.Val?.Value;
  }
  
  private static bool CmpBulletSizePoints(DXDraw.Level7ParagraphProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BulletSizePoints>()?.Val?.Value == value;
  }
  
  private static void SetBulletSizePoints(DXDraw.Level7ParagraphProperties openXmlElement, Int32? value)
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
  
  private static Boolean? GetBulletFontText(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.BulletFontText>() != null;
  }
  
  private static bool CmpBulletFontText(DXDraw.Level7ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.BulletFontText>() != null == value;
  }
  
  private static void SetBulletFontText(DXDraw.Level7ParagraphProperties openXmlElement, Boolean? value)
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
  
  private static DMDraws.TextFontType? GetBulletFont(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.TextFontTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.BulletFont>());
  }
  
  private static bool CmpBulletFont(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TextFontTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.BulletFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBulletFont(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.TextFontType? value)
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
  
  private static Boolean? GetNoBullet(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoBullet>() != null;
  }
  
  private static bool CmpNoBullet(DXDraw.Level7ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoBullet>() != null == value;
  }
  
  private static void SetNoBullet(DXDraw.Level7ParagraphProperties openXmlElement, Boolean? value)
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
  
  private static DMDraws.AutoNumberedBullet? GetAutoNumberedBullet(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.AutoNumberedBulletConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.AutoNumberedBullet>());
  }
  
  private static bool CmpAutoNumberedBullet(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.AutoNumberedBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AutoNumberedBulletConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.AutoNumberedBullet>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAutoNumberedBullet(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.AutoNumberedBullet? value)
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
  
  private static DMDraws.CharacterBullet? GetCharacterBullet(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.CharacterBulletConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.CharacterBullet>());
  }
  
  private static bool CmpCharacterBullet(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.CharacterBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CharacterBulletConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.CharacterBullet>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCharacterBullet(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.CharacterBullet? value)
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
  
  private static DMDraws.PictureBullet? GetPictureBullet(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.PictureBulletConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PictureBullet>());
  }
  
  private static bool CmpPictureBullet(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.PictureBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PictureBulletConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.PictureBullet>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPictureBullet(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.PictureBullet? value)
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
  
  private static DMDraws.TabStopList? GetTabStopList(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.TabStopListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.TabStopList>());
  }
  
  private static bool CmpTabStopList(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.TabStopList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TabStopListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.TabStopList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTabStopList(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.TabStopList? value)
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
  
  private static DMDraws.DefaultRunProperties? GetDefaultRunProperties(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.DefaultRunPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.DefaultRunProperties>());
  }
  
  private static bool CmpDefaultRunProperties(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.DefaultRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.DefaultRunPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.DefaultRunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDefaultRunProperties(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.DefaultRunProperties? value)
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
  
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.Level7ParagraphProperties openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDraw.Level7ParagraphProperties openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.Level7ParagraphProperties? CreateModelElement(DXDraw.Level7ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Level7ParagraphProperties();
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
  
  public static bool CompareModelElement(DXDraw.Level7ParagraphProperties? openXmlElement, DMDraws.Level7ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineSpacing(openXmlElement, value.LineSpacing, diffs, objName))
        ok = false;
      if (!CmpSpaceBefore(openXmlElement, value.SpaceBefore, diffs, objName))
        ok = false;
      if (!CmpSpaceAfter(openXmlElement, value.SpaceAfter, diffs, objName))
        ok = false;
      if (!CmpBulletColorText(openXmlElement, value.BulletColorText, diffs, objName))
        ok = false;
      if (!CmpBulletColor(openXmlElement, value.BulletColor, diffs, objName))
        ok = false;
      if (!CmpBulletSizeText(openXmlElement, value.BulletSizeText, diffs, objName))
        ok = false;
      if (!CmpBulletSizePercentage(openXmlElement, value.BulletSizePercentage, diffs, objName))
        ok = false;
      if (!CmpBulletSizePoints(openXmlElement, value.BulletSizePoints, diffs, objName))
        ok = false;
      if (!CmpBulletFontText(openXmlElement, value.BulletFontText, diffs, objName))
        ok = false;
      if (!CmpBulletFont(openXmlElement, value.BulletFont, diffs, objName))
        ok = false;
      if (!CmpNoBullet(openXmlElement, value.NoBullet, diffs, objName))
        ok = false;
      if (!CmpAutoNumberedBullet(openXmlElement, value.AutoNumberedBullet, diffs, objName))
        ok = false;
      if (!CmpCharacterBullet(openXmlElement, value.CharacterBullet, diffs, objName))
        ok = false;
      if (!CmpPictureBullet(openXmlElement, value.PictureBullet, diffs, objName))
        ok = false;
      if (!CmpTabStopList(openXmlElement, value.TabStopList, diffs, objName))
        ok = false;
      if (!CmpDefaultRunProperties(openXmlElement, value.DefaultRunProperties, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Level7ParagraphProperties? value)
    where OpenXmlElementType: DXDraw.Level7ParagraphProperties, new()
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
