namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Character Bullet.
/// </summary>
public static class CharacterBulletConverter
{
  /// <summary>
  /// Bullet Character
  /// </summary>
  private static String? GetChar(DXDraw.CharacterBullet openXmlElement)
  {
    return openXmlElement?.Char?.Value;
  }
  
  private static void SetChar(DXDraw.CharacterBullet openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Char = new StringValue { Value = value };
    else
      openXmlElement.Char = null;
  }
  
  public static DMDraws.CharacterBullet? CreateModelElement(DXDraw.CharacterBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.CharacterBullet();
      value.Char = GetChar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CharacterBullet? value)
    where OpenXmlElementType: DXDraw.CharacterBullet, new()
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
