namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Character Bullet.
/// </summary>
public static class CharacterBulletConverter
{
  /// <summary>
  /// Bullet Character
  /// </summary>
  public static String? GetChar(DocumentFormat.OpenXml.Drawing.CharacterBullet? openXmlElement)
  {
    return openXmlElement?.Char?.Value;
  }
  
  public static void SetChar(DocumentFormat.OpenXml.Drawing.CharacterBullet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Char = new StringValue { Value = value };
      else
        openXmlElement.Char = null;
  }
  
  public static DocumentModel.Drawings.CharacterBullet? CreateModelElement(DocumentFormat.OpenXml.Drawing.CharacterBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CharacterBullet();
      value.Char = GetChar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.CharacterBullet? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.CharacterBullet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChar(openXmlElement, value?.Char);
      return openXmlElement;
    }
    return default;
  }
}
