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
    return StringValueConverter.GetValue(openXmlElement?.Char);
  }
  
  private static bool CmpChar(DXDraw.CharacterBullet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Char, value, diffs, objName, "Char");
  }
  
  private static void SetChar(DXDraw.CharacterBullet openXmlElement, String? value)
  {
    openXmlElement.Char = StringValueConverter.CreateStringValue(value);
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CharacterBullet value)
    where OpenXmlElementType: DXDraw.CharacterBullet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.CharacterBullet openXmlElement, DMDraws.CharacterBullet value)
  {
    SetChar(openXmlElement, value?.Char);
  }
}
