namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the DiagramAutoBullet Class.
/// </summary>
public static class DiagramAutoBulletConverter
{
  /// <summary>
  /// prefix, this property is only available in Office 2019 and later.
  /// </summary>
  private static String? GetAutoBulletPrefix(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    return openXmlElement?.AutoBulletPrefix?.Value;
  }
  
  private static bool CmpAutoBulletPrefix(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AutoBulletPrefix?.Value == value;
  }
  
  private static void SetAutoBulletPrefix(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AutoBulletPrefix = new StringValue { Value = value };
    else
      openXmlElement.AutoBulletPrefix = null;
  }
  
  /// <summary>
  /// leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  private static Boolean? GetLeadZeros(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    return openXmlElement?.LeadZeros?.Value;
  }
  
  private static bool CmpLeadZeros(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LeadZeros?.Value == value;
  }
  
  private static void SetLeadZeros(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LeadZeros = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LeadZeros = null;
  }
  
  /// <summary>
  /// No Bullet.
  /// </summary>
  private static Boolean? GetNoBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoBullet>() != null;
  }
  
  private static bool CmpNoBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoBullet>() != null == value;
  }
  
  private static void SetNoBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// Auto-Numbered Bullet.
  /// </summary>
  private static DMDraws.AutoNumberedBullet? GetAutoNumberedBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    return DMXDraws.AutoNumberedBulletConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.AutoNumberedBullet>());
  }
  
  private static bool CmpAutoNumberedBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, DMDraws.AutoNumberedBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AutoNumberedBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AutoNumberedBullet>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAutoNumberedBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, DMDraws.AutoNumberedBullet? value)
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
  
  /// <summary>
  /// Character Bullet.
  /// </summary>
  private static DMDraws.CharacterBullet? GetCharacterBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    return DMXDraws.CharacterBulletConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.CharacterBullet>());
  }
  
  private static bool CmpCharacterBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, DMDraws.CharacterBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CharacterBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.CharacterBullet>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCharacterBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, DMDraws.CharacterBullet? value)
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
  
  /// <summary>
  /// Picture Bullet.
  /// </summary>
  private static DMDraws.PictureBullet? GetPictureBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    return DMXDraws.PictureBulletConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PictureBullet>());
  }
  
  private static bool CmpPictureBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, DMDraws.PictureBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PictureBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PictureBullet>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPictureBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, DMDraws.PictureBullet? value)
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
  
  public static DMDrawsDgm1.DiagramAutoBullet? CreateModelElement(DXO2019DrawDgm11.DiagramAutoBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgm1.DiagramAutoBullet();
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
  
  public static bool CompareModelElement(DXO2019DrawDgm11.DiagramAutoBullet? openXmlElement, DMDrawsDgm1.DiagramAutoBullet? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgm1.DiagramAutoBullet? value)
    where OpenXmlElementType: DXO2019DrawDgm11.DiagramAutoBullet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAutoBulletPrefix(openXmlElement, value?.AutoBulletPrefix);
      SetLeadZeros(openXmlElement, value?.LeadZeros);
      SetNoBullet(openXmlElement, value?.NoBullet);
      SetAutoNumberedBullet(openXmlElement, value?.AutoNumberedBullet);
      SetCharacterBullet(openXmlElement, value?.CharacterBullet);
      SetPictureBullet(openXmlElement, value?.PictureBullet);
      return openXmlElement;
    }
    return default;
  }
}
