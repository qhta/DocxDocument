namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the DiagramAutoBullet Class.
/// </summary>
public static class DiagramAutoBulletConverter
{
  /// <summary>
  /// prefix, this property is only available in Office 2019 and later.
  /// </summary>
  private static String? GetAutoBulletPrefix(DXO19DD11.DiagramAutoBullet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AutoBulletPrefix);
  }
  
  private static bool CmpAutoBulletPrefix(DXO19DD11.DiagramAutoBullet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AutoBulletPrefix, value, diffs, objName, "AutoBulletPrefix");
  }
  
  private static void SetAutoBulletPrefix(DXO19DD11.DiagramAutoBullet openXmlElement, String? value)
  {
    openXmlElement.AutoBulletPrefix = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  private static Boolean? GetLeadZeros(DXO19DD11.DiagramAutoBullet openXmlElement)
  {
    return openXmlElement?.LeadZeros?.Value;
  }
  
  private static bool CmpLeadZeros(DXO19DD11.DiagramAutoBullet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LeadZeros?.Value == value) return true;
    diffs?.Add(objName, "LeadZeros", openXmlElement?.LeadZeros?.Value, value);
    return false;
  }
  
  private static void SetLeadZeros(DXO19DD11.DiagramAutoBullet openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LeadZeros = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LeadZeros = null;
  }
  
  /// <summary>
  /// No Bullet.
  /// </summary>
  private static Boolean? GetNoBullet(DXO19DD11.DiagramAutoBullet openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoBullet>() != null;
  }
  
  private static bool CmpNoBullet(DXO19DD11.DiagramAutoBullet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoBullet>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.NoBullet", val, value);
    return false;
  }
  
  private static void SetNoBullet(DXO19DD11.DiagramAutoBullet openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// Auto-Numbered Bullet.
  /// </summary>
  private static DMD.AutoNumberedBullet? GetAutoNumberedBullet(DXO19DD11.DiagramAutoBullet openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AutoNumberedBullet>();
    if (element != null)
      return DMXD.AutoNumberedBulletConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAutoNumberedBullet(DXO19DD11.DiagramAutoBullet openXmlElement, DMD.AutoNumberedBullet? value, DiffList? diffs, string? objName)
  {
    return DMXD.AutoNumberedBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AutoNumberedBullet>(), value, diffs, objName);
  }
  
  private static void SetAutoNumberedBullet(DXO19DD11.DiagramAutoBullet openXmlElement, DMD.AutoNumberedBullet? value)
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
  
  /// <summary>
  /// Character Bullet.
  /// </summary>
  private static DMD.CharacterBullet? GetCharacterBullet(DXO19DD11.DiagramAutoBullet openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CharacterBullet>();
    if (element != null)
      return DMXD.CharacterBulletConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCharacterBullet(DXO19DD11.DiagramAutoBullet openXmlElement, DMD.CharacterBullet? value, DiffList? diffs, string? objName)
  {
    return DMXD.CharacterBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CharacterBullet>(), value, diffs, objName);
  }
  
  private static void SetCharacterBullet(DXO19DD11.DiagramAutoBullet openXmlElement, DMD.CharacterBullet? value)
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
  
  /// <summary>
  /// Picture Bullet.
  /// </summary>
  private static DMD.PictureBullet? GetPictureBullet(DXO19DD11.DiagramAutoBullet openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PictureBullet>();
    if (element != null)
      return DMXD.PictureBulletConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureBullet(DXO19DD11.DiagramAutoBullet openXmlElement, DMD.PictureBullet? value, DiffList? diffs, string? objName)
  {
    return DMXD.PictureBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PictureBullet>(), value, diffs, objName);
  }
  
  private static void SetPictureBullet(DXO19DD11.DiagramAutoBullet openXmlElement, DMD.PictureBullet? value)
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
  
  public static DocumentModel.Drawings.Diagram1.DiagramAutoBullet? CreateModelElement(DXO19DD11.DiagramAutoBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagram1.DiagramAutoBullet();
      value.AutoBulletPrefix = GetAutoBulletPrefix(openXmlElement);
      value.LeadZeros = GetLeadZeros(openXmlElement);
      value.NoBullet = GetNoBullet(openXmlElement);
      value.AutoNumberedBullet = GetAutoNumberedBullet(openXmlElement);
      value.CharacterBullet = GetCharacterBullet(openXmlElement);
      value.PictureBullet = GetPictureBullet(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO19DD11.DiagramAutoBullet? openXmlElement, DMDD1.DiagramAutoBullet? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAutoBulletPrefix(openXmlElement, value.AutoBulletPrefix, diffs, objName))
        ok = false;
      if (!CmpLeadZeros(openXmlElement, value.LeadZeros, diffs, objName))
        ok = false;
      if (!CmpNoBullet(openXmlElement, value.NoBullet, diffs, objName))
        ok = false;
      if (!CmpAutoNumberedBullet(openXmlElement, value.AutoNumberedBullet, diffs, objName))
        ok = false;
      if (!CmpCharacterBullet(openXmlElement, value.CharacterBullet, diffs, objName))
        ok = false;
      if (!CmpPictureBullet(openXmlElement, value.PictureBullet, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD1.DiagramAutoBullet value)
    where OpenXmlElementType: DXO19DD11.DiagramAutoBullet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO19DD11.DiagramAutoBullet openXmlElement, DMDD1.DiagramAutoBullet value)
  {
    SetAutoBulletPrefix(openXmlElement, value?.AutoBulletPrefix);
    SetLeadZeros(openXmlElement, value?.LeadZeros);
    SetNoBullet(openXmlElement, value?.NoBullet);
    SetAutoNumberedBullet(openXmlElement, value?.AutoNumberedBullet);
    SetCharacterBullet(openXmlElement, value?.CharacterBullet);
    SetPictureBullet(openXmlElement, value?.PictureBullet);
  }
}
