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
