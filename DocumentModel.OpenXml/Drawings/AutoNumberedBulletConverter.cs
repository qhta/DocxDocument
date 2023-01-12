namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Auto-Numbered Bullet.
/// </summary>
public static class AutoNumberedBulletConverter
{
  /// <summary>
  /// Bullet Autonumbering Type
  /// </summary>
  public static DocumentModel.Drawings.TextAutoNumberSchemeKind? GetType(DocumentFormat.OpenXml.Drawing.AutoNumberedBullet? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues, DocumentModel.Drawings.TextAutoNumberSchemeKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.AutoNumberedBullet? openXmlElement, DocumentModel.Drawings.TextAutoNumberSchemeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues, DocumentModel.Drawings.TextAutoNumberSchemeKind>(value);
  }
  
  /// <summary>
  /// Start Numbering At
  /// </summary>
  public static Int32? GetStartAt(DocumentFormat.OpenXml.Drawing.AutoNumberedBullet? openXmlElement)
  {
    return openXmlElement?.StartAt?.Value;
  }
  
  public static void SetStartAt(DocumentFormat.OpenXml.Drawing.AutoNumberedBullet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartAt = value;
  }
  
  public static DocumentModel.Drawings.AutoNumberedBullet? CreateModelElement(DocumentFormat.OpenXml.Drawing.AutoNumberedBullet? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AutoNumberedBullet? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AutoNumberedBullet, new()
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
