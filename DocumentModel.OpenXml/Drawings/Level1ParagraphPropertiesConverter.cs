namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List Level 1 Text Style.
/// </summary>
public static class Level1ParagraphPropertiesConverter
{
  private static DMD.LineSpacing? GetLineSpacing(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LineSpacing>();
    if (element != null)
      return DMXD.LineSpacingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineSpacing(DXD.Level1ParagraphProperties openXmlElement, DMD.LineSpacing? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineSpacingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LineSpacing>(), value, diffs, objName, propName);
  }
  
  private static void SetLineSpacing(DXD.Level1ParagraphProperties openXmlElement, DMD.LineSpacing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LineSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineSpacingConverter.CreateOpenXmlElement<DXD.LineSpacing>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.SpaceBefore? GetSpaceBefore(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SpaceBefore>();
    if (element != null)
      return DMXD.SpaceBeforeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSpaceBefore(DXD.Level1ParagraphProperties openXmlElement, DMD.SpaceBefore? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SpaceBeforeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SpaceBefore>(), value, diffs, objName, propName);
  }
  
  private static void SetSpaceBefore(DXD.Level1ParagraphProperties openXmlElement, DMD.SpaceBefore? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SpaceBefore>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SpaceBeforeConverter.CreateOpenXmlElement<DXD.SpaceBefore>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.SpaceAfter? GetSpaceAfter(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SpaceAfter>();
    if (element != null)
      return DMXD.SpaceAfterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSpaceAfter(DXD.Level1ParagraphProperties openXmlElement, DMD.SpaceAfter? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SpaceAfterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SpaceAfter>(), value, diffs, objName, propName);
  }
  
  private static void SetSpaceAfter(DXD.Level1ParagraphProperties openXmlElement, DMD.SpaceAfter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SpaceAfter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SpaceAfterConverter.CreateOpenXmlElement<DXD.SpaceAfter>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetBulletColorText(DXD.Level1ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.BulletColorText>() != null;
  }
  
  private static bool CmpBulletColorText(DXD.Level1ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.BulletColorText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.BulletColorText", val, value);
    return false;
  }
  
  private static void SetBulletColorText(DXD.Level1ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.BulletColorText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.BulletColorText();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.BulletColor? GetBulletColor(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BulletColor>();
    if (element != null)
      return DMXD.BulletColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBulletColor(DXD.Level1ParagraphProperties openXmlElement, DMD.BulletColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BulletColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BulletColor>(), value, diffs, objName, propName);
  }
  
  private static void SetBulletColor(DXD.Level1ParagraphProperties openXmlElement, DMD.BulletColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BulletColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BulletColorConverter.CreateOpenXmlElement<DXD.BulletColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetBulletSizeText(DXD.Level1ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.BulletSizeText>() != null;
  }
  
  private static bool CmpBulletSizeText(DXD.Level1ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.BulletSizeText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.BulletSizeText", val, value);
    return false;
  }
  
  private static void SetBulletSizeText(DXD.Level1ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.BulletSizeText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.BulletSizeText();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetBulletSizePercentage(DXD.Level1ParagraphProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.BulletSizePercentage>()?.Val);
  }
  
  private static bool CmpBulletSizePercentage(DXD.Level1ParagraphProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.BulletSizePercentage>()?.Val, value, diffs, objName, "BulletSizePercentage");
  }
  
  private static void SetBulletSizePercentage(DXD.Level1ParagraphProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.BulletSizePercentage,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBulletSizePoints(DXD.Level1ParagraphProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.BulletSizePoints>()?.Val);
  }
  
  private static bool CmpBulletSizePoints(DXD.Level1ParagraphProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.BulletSizePoints>()?.Val, value, diffs, objName, "BulletSizePoints");
  }
  
  private static void SetBulletSizePoints(DXD.Level1ParagraphProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.BulletSizePoints,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetBulletFontText(DXD.Level1ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.BulletFontText>() != null;
  }
  
  private static bool CmpBulletFontText(DXD.Level1ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.BulletFontText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.BulletFontText", val, value);
    return false;
  }
  
  private static void SetBulletFontText(DXD.Level1ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.BulletFontText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.BulletFontText();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.TextFontType? GetBulletFont(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BulletFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBulletFont(DXD.Level1ParagraphProperties openXmlElement, DMD.TextFontType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BulletFont>(), value, diffs, objName, propName);
  }
  
  private static void SetBulletFont(DXD.Level1ParagraphProperties openXmlElement, DMD.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BulletFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.BulletFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetNoBullet(DXD.Level1ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoBullet>() != null;
  }
  
  private static bool CmpNoBullet(DXD.Level1ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoBullet>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.NoBullet", val, value);
    return false;
  }
  
  private static void SetNoBullet(DXD.Level1ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.NoBullet>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.NoBullet();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.AutoNumberedBullet? GetAutoNumberedBullet(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AutoNumberedBullet>();
    if (element != null)
      return DMXD.AutoNumberedBulletConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAutoNumberedBullet(DXD.Level1ParagraphProperties openXmlElement, DMD.AutoNumberedBullet? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AutoNumberedBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AutoNumberedBullet>(), value, diffs, objName, propName);
  }
  
  private static void SetAutoNumberedBullet(DXD.Level1ParagraphProperties openXmlElement, DMD.AutoNumberedBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AutoNumberedBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AutoNumberedBulletConverter.CreateOpenXmlElement<DXD.AutoNumberedBullet>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.CharacterBullet? GetCharacterBullet(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CharacterBullet>();
    if (element != null)
      return DMXD.CharacterBulletConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCharacterBullet(DXD.Level1ParagraphProperties openXmlElement, DMD.CharacterBullet? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.CharacterBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CharacterBullet>(), value, diffs, objName, propName);
  }
  
  private static void SetCharacterBullet(DXD.Level1ParagraphProperties openXmlElement, DMD.CharacterBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CharacterBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CharacterBulletConverter.CreateOpenXmlElement<DXD.CharacterBullet>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PictureBullet? GetPictureBullet(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PictureBullet>();
    if (element != null)
      return DMXD.PictureBulletConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureBullet(DXD.Level1ParagraphProperties openXmlElement, DMD.PictureBullet? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PictureBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PictureBullet>(), value, diffs, objName, propName);
  }
  
  private static void SetPictureBullet(DXD.Level1ParagraphProperties openXmlElement, DMD.PictureBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PictureBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PictureBulletConverter.CreateOpenXmlElement<DXD.PictureBullet>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.TabStopList? GetTabStopList(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TabStopList>();
    if (element != null)
      return DMXD.TabStopListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTabStopList(DXD.Level1ParagraphProperties openXmlElement, DMD.TabStopList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TabStopListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TabStopList>(), value, diffs, objName, propName);
  }
  
  private static void SetTabStopList(DXD.Level1ParagraphProperties openXmlElement, DMD.TabStopList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TabStopList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TabStopListConverter.CreateOpenXmlElement<DXD.TabStopList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.DefaultRunProperties? GetDefaultRunProperties(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.DefaultRunProperties>();
    if (element != null)
      return DMXD.DefaultRunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDefaultRunProperties(DXD.Level1ParagraphProperties openXmlElement, DMD.DefaultRunProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.DefaultRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.DefaultRunProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetDefaultRunProperties(DXD.Level1ParagraphProperties openXmlElement, DMD.DefaultRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.DefaultRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.DefaultRunPropertiesConverter.CreateOpenXmlElement<DXD.DefaultRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ExtensionList? GetExtensionList(DXD.Level1ParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.Level1ParagraphProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.Level1ParagraphProperties openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Level1ParagraphProperties? CreateModelElement(DXD.Level1ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Level1ParagraphProperties();
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
  
  public static bool CompareModelElement(DXD.Level1ParagraphProperties? openXmlElement, DMD.Level1ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineSpacing(openXmlElement, value.LineSpacing, diffs, objName, propName))
        ok = false;
      if (!CmpSpaceBefore(openXmlElement, value.SpaceBefore, diffs, objName, propName))
        ok = false;
      if (!CmpSpaceAfter(openXmlElement, value.SpaceAfter, diffs, objName, propName))
        ok = false;
      if (!CmpBulletColorText(openXmlElement, value.BulletColorText, diffs, objName, propName))
        ok = false;
      if (!CmpBulletColor(openXmlElement, value.BulletColor, diffs, objName, propName))
        ok = false;
      if (!CmpBulletSizeText(openXmlElement, value.BulletSizeText, diffs, objName, propName))
        ok = false;
      if (!CmpBulletSizePercentage(openXmlElement, value.BulletSizePercentage, diffs, objName, propName))
        ok = false;
      if (!CmpBulletSizePoints(openXmlElement, value.BulletSizePoints, diffs, objName, propName))
        ok = false;
      if (!CmpBulletFontText(openXmlElement, value.BulletFontText, diffs, objName, propName))
        ok = false;
      if (!CmpBulletFont(openXmlElement, value.BulletFont, diffs, objName, propName))
        ok = false;
      if (!CmpNoBullet(openXmlElement, value.NoBullet, diffs, objName, propName))
        ok = false;
      if (!CmpAutoNumberedBullet(openXmlElement, value.AutoNumberedBullet, diffs, objName, propName))
        ok = false;
      if (!CmpCharacterBullet(openXmlElement, value.CharacterBullet, diffs, objName, propName))
        ok = false;
      if (!CmpPictureBullet(openXmlElement, value.PictureBullet, diffs, objName, propName))
        ok = false;
      if (!CmpTabStopList(openXmlElement, value.TabStopList, diffs, objName, propName))
        ok = false;
      if (!CmpDefaultRunProperties(openXmlElement, value.DefaultRunProperties, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Level1ParagraphProperties value)
    where OpenXmlElementType: DXD.Level1ParagraphProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Level1ParagraphProperties openXmlElement, DMD.Level1ParagraphProperties value)
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
