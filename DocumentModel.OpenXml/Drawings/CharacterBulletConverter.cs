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
  
  private static bool CmpChar(DXDraw.CharacterBullet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Char?.Value == value) return true;
    diffs?.Add(objName, "Char", openXmlElement?.Char?.Value, value);
    return false;
  }
  
  private static void SetChar(DXDraw.CharacterBullet openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Char = new StringValue { Value = value };
    else
      openXmlElement.Char = null;
  }
  
  public static DocumentModel.Drawings.CharacterBullet? CreateModelElement(DXDraw.CharacterBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CharacterBullet();
      value.Char = GetChar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.CharacterBullet? openXmlElement, DMDraws.CharacterBullet? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChar(openXmlElement, value.Char, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
