namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public static class AutoNumberedBulletConverter
{
  /// <summary>
  /// Bullet Autonumbering Type
  /// </summary>
  private static DMD.TextAutoNumberSchemeKind? GetType(DXD.AutoNumberedBullet openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues, DMD.TextAutoNumberSchemeKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXD.AutoNumberedBullet openXmlElement, DMD.TextAutoNumberSchemeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues, DMD.TextAutoNumberSchemeKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXD.AutoNumberedBullet openXmlElement, DMD.TextAutoNumberSchemeKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues, DMD.TextAutoNumberSchemeKind>(value);
  }
  
  /// <summary>
  /// Start Numbering At
  /// </summary>
  private static Int32? GetStartAt(DXD.AutoNumberedBullet openXmlElement)
  {
    return openXmlElement?.StartAt?.Value;
  }
  
  private static bool CmpStartAt(DXD.AutoNumberedBullet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StartAt?.Value == value) return true;
    diffs?.Add(objName, "StartAt", openXmlElement?.StartAt?.Value, value);
    return false;
  }
  
  private static void SetStartAt(DXD.AutoNumberedBullet openXmlElement, Int32? value)
  {
    openXmlElement.StartAt = value;
  }
  
  public static DocumentModel.Drawings.AutoNumberedBullet? CreateModelElement(DXD.AutoNumberedBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AutoNumberedBullet();
      value.Type = GetType(openXmlElement);
      value.StartAt = GetStartAt(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AutoNumberedBullet? openXmlElement, DMD.AutoNumberedBullet? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AutoNumberedBullet value)
    where OpenXmlElementType: DXD.AutoNumberedBullet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AutoNumberedBullet openXmlElement, DMD.AutoNumberedBullet value)
  {
    SetType(openXmlElement, value?.Type);
    SetStartAt(openXmlElement, value?.StartAt);
  }
}
