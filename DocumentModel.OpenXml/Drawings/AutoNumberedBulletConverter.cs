namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public static class AutoNumberedBulletConverter
{
  /// <summary>
  /// Bullet Autonumbering Type
  /// </summary>
  private static DMDraws.TextAutoNumberSchemeKind? GetType(DXDraw.AutoNumberedBullet openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues, DMDraws.TextAutoNumberSchemeKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDraw.AutoNumberedBullet openXmlElement, DMDraws.TextAutoNumberSchemeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues, DMDraws.TextAutoNumberSchemeKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXDraw.AutoNumberedBullet openXmlElement, DMDraws.TextAutoNumberSchemeKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues, DMDraws.TextAutoNumberSchemeKind>(value);
  }
  
  /// <summary>
  /// Start Numbering At
  /// </summary>
  private static Int32? GetStartAt(DXDraw.AutoNumberedBullet openXmlElement)
  {
    return openXmlElement.StartAt?.Value;
  }
  
  private static bool CmpStartAt(DXDraw.AutoNumberedBullet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.StartAt?.Value == value;
  }
  
  private static void SetStartAt(DXDraw.AutoNumberedBullet openXmlElement, Int32? value)
  {
    openXmlElement.StartAt = value;
  }
  
  public static DMDraws.AutoNumberedBullet? CreateModelElement(DXDraw.AutoNumberedBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AutoNumberedBullet();
      value.Type = GetType(openXmlElement);
      value.StartAt = GetStartAt(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AutoNumberedBullet? openXmlElement, DMDraws.AutoNumberedBullet? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpStartAt(openXmlElement, value.StartAt, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AutoNumberedBullet? value)
    where OpenXmlElementType: DXDraw.AutoNumberedBullet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetStartAt(openXmlElement, value?.StartAt);
      return openXmlElement;
    }
    return default;
  }
}
