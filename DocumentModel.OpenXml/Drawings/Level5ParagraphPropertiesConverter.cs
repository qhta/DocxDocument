namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List Level 5 Text Style converter from/to OpenXml.
///</summary>
public static class Level5ParagraphPropertiesConverter
{
  private static DMDraws.LineSpacing? GetLineSpacing(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.LineSpacing>();
    if (element != null)
      return DMXDraws.LineSpacingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineSpacing(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.LineSpacing? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineSpacingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LineSpacing>(), value, diffs, objName);
  }
  
  private static void SetLineSpacing(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.LineSpacing? value)
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
  
  private static DMDraws.SpaceBefore? GetSpaceBefore(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SpaceBefore>();
    if (element != null)
      return DMXDraws.SpaceBeforeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSpaceBefore(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.SpaceBefore? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SpaceBeforeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SpaceBefore>(), value, diffs, objName);
  }
  
  private static void SetSpaceBefore(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.SpaceBefore? value)
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
  
  private static DMDraws.SpaceAfter? GetSpaceAfter(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SpaceAfter>();
    if (element != null)
      return DMXDraws.SpaceAfterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSpaceAfter(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.SpaceAfter? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SpaceAfterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SpaceAfter>(), value, diffs, objName);
  }
  
  private static void SetSpaceAfter(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.SpaceAfter? value)
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
  
  private static Boolean? GetBulletColorText(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.BulletColorText>() != null;
  }
  
  private static bool CmpBulletColorText(DXDraw.Level5ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.BulletColorText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.BulletColorText", val, value);
    return false;
  }
  
  private static void SetBulletColorText(DXDraw.Level5ParagraphProperties openXmlElement, Boolean? value)
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
  
  private static DMDraws.BulletColor? GetBulletColor(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BulletColor>();
    if (element != null)
      return DMXDraws.BulletColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBulletColor(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.BulletColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BulletColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BulletColor>(), value, diffs, objName);
  }
  
  private static void SetBulletColor(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.BulletColor? value)
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
  
  private static Boolean? GetBulletSizeText(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.BulletSizeText>() != null;
  }
  
  private static bool CmpBulletSizeText(DXDraw.Level5ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.BulletSizeText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.BulletSizeText", val, value);
    return false;
  }
  
  private static void SetBulletSizeText(DXDraw.Level5ParagraphProperties openXmlElement, Boolean? value)
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
  
  private static Int32? GetBulletSizePercentage(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.BulletSizePercentage>()?.Val);
  }
  
  private static bool CmpBulletSizePercentage(DXDraw.Level5ParagraphProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.BulletSizePercentage>()?.Val, value, diffs, objName, "BulletSizePercentage");
  }
  
  private static void SetBulletSizePercentage(DXDraw.Level5ParagraphProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.BulletSizePercentage,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBulletSizePoints(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.BulletSizePoints>()?.Val);
  }
  
  private static bool CmpBulletSizePoints(DXDraw.Level5ParagraphProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.BulletSizePoints>()?.Val, value, diffs, objName, "BulletSizePoints");
  }
  
  private static void SetBulletSizePoints(DXDraw.Level5ParagraphProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.BulletSizePoints,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetBulletFontText(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.BulletFontText>() != null;
  }
  
  private static bool CmpBulletFontText(DXDraw.Level5ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.BulletFontText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.BulletFontText", val, value);
    return false;
  }
  
  private static void SetBulletFontText(DXDraw.Level5ParagraphProperties openXmlElement, Boolean? value)
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
  
  private static DMDraws.TextFontType? GetBulletFont(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BulletFont>();
    if (element != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBulletFont(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BulletFont>(), value, diffs, objName);
  }
  
  private static void SetBulletFont(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.TextFontType? value)
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
  
  private static Boolean? GetNoBullet(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoBullet>() != null;
  }
  
  private static bool CmpNoBullet(DXDraw.Level5ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.NoBullet>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.NoBullet", val, value);
    return false;
  }
  
  private static void SetNoBullet(DXDraw.Level5ParagraphProperties openXmlElement, Boolean? value)
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
  
  private static DMDraws.AutoNumberedBullet? GetAutoNumberedBullet(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.AutoNumberedBullet>();
    if (element != null)
      return DMXDraws.AutoNumberedBulletConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAutoNumberedBullet(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.AutoNumberedBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AutoNumberedBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AutoNumberedBullet>(), value, diffs, objName);
  }
  
  private static void SetAutoNumberedBullet(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.AutoNumberedBullet? value)
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
  
  private static DMDraws.CharacterBullet? GetCharacterBullet(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.CharacterBullet>();
    if (element != null)
      return DMXDraws.CharacterBulletConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCharacterBullet(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.CharacterBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CharacterBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.CharacterBullet>(), value, diffs, objName);
  }
  
  private static void SetCharacterBullet(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.CharacterBullet? value)
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
  
  private static DMDraws.PictureBullet? GetPictureBullet(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PictureBullet>();
    if (element != null)
      return DMXDraws.PictureBulletConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureBullet(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.PictureBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PictureBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PictureBullet>(), value, diffs, objName);
  }
  
  private static void SetPictureBullet(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.PictureBullet? value)
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
  
  private static DMDraws.TabStopList? GetTabStopList(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.TabStopList>();
    if (element != null)
      return DMXDraws.TabStopListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTabStopList(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.TabStopList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TabStopListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.TabStopList>(), value, diffs, objName);
  }
  
  private static void SetTabStopList(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.TabStopList? value)
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
  
  private static DMDraws.DefaultRunProperties? GetDefaultRunProperties(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.DefaultRunProperties>();
    if (element != null)
      return DMXDraws.DefaultRunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDefaultRunProperties(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.DefaultRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.DefaultRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.DefaultRunProperties>(), value, diffs, objName);
  }
  
  private static void SetDefaultRunProperties(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.DefaultRunProperties? value)
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
  
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.Level5ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Level5ParagraphProperties? CreateModelElement(DXDraw.Level5ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Level5ParagraphProperties();
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
  
  public static bool CompareModelElement(DXDraw.Level5ParagraphProperties? openXmlElement, DMDraws.Level5ParagraphProperties? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Level5ParagraphProperties value)
    where OpenXmlElementType: DXDraw.Level5ParagraphProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Level5ParagraphProperties openXmlElement, DMDraws.Level5ParagraphProperties value)
  {
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
  }
}
