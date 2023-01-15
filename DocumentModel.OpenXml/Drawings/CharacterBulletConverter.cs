using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Character Bullet.
/// </summary>
public static class CharacterBulletConverter
{
  /// <summary>
  ///   Bullet Character
  /// </summary>
  public static String? GetChar(CharacterBullet? openXmlElement)
  {
    return openXmlElement?.Char?.Value;
  }

  public static void SetChar(CharacterBullet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Char = new StringValue { Value = value };
      else
        openXmlElement.Char = null;
  }

  public static DocumentModel.Drawings.CharacterBullet? CreateModelElement(CharacterBullet? openXmlElement)
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
    where OpenXmlElementType : CharacterBullet, new()
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