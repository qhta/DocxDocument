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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStartAt(DocumentFormat.OpenXml.Drawing.AutoNumberedBullet? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
