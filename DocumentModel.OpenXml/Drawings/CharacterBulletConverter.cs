namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Character Bullet.
/// </summary>
public static class CharacterBulletConverter
{
  /// <summary>
  /// Bullet Character
  /// </summary>
  private static String? GetChar(DXD.CharacterBullet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Char);
  }
  
  private static bool CmpChar(DXD.CharacterBullet openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Char, value, diffs, objName, "Char");
  }
  
  private static void SetChar(DXD.CharacterBullet openXmlElement, String? value)
  {
    openXmlElement.Char = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.CharacterBullet? CreateModelElement(DXD.CharacterBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CharacterBullet();
      value.Char = GetChar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.CharacterBullet? openXmlElement, DMD.CharacterBullet? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChar(openXmlElement, value.Char, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.CharacterBullet value)
    where OpenXmlElementType: DXD.CharacterBullet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.CharacterBullet openXmlElement, DMD.CharacterBullet value)
  {
    SetChar(openXmlElement, value?.Char);
  }
}
