namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextFontType Class.
/// </summary>
public static class TextFontTypeConverter
{
  /// <summary>
  /// Text Typeface
  /// </summary>
  private static String? GetTypeface(DXDraw.TextFontType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Typeface);
  }
  
  private static bool CmpTypeface(DXDraw.TextFontType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Typeface, value, diffs, objName, "Typeface");
  }
  
  private static void SetTypeface(DXDraw.TextFontType openXmlElement, String? value)
  {
    openXmlElement.Typeface = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  private static DM.HexBinary? GetPanose(DXDraw.TextFontType openXmlElement)
  {
    if (openXmlElement?.Panose?.Value != null)
      return Convert.FromHexString(openXmlElement.Panose.Value);
    return null;
  }
  
  private static bool CmpPanose(DXDraw.TextFontType openXmlElement, DM.HexBinary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Panose?.Value != null && value != null)
      if (Convert.FromHexString(openXmlElement.Panose.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement == null && openXmlElement?.Panose?.Value == null && value == null) return true;
    diffs?.Add(objName, "Panose", openXmlElement?.Panose?.Value, value);
    return false;
  }
  
  private static void SetPanose(DXDraw.TextFontType openXmlElement, DM.HexBinary? value)
  {
    if (value != null)
      openXmlElement.Panose = Convert.ToHexString(value);
    else
      openXmlElement.Panose = null;
  }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  private static SByte? GetPitchFamily(DXDraw.TextFontType openXmlElement)
  {
    return openXmlElement?.PitchFamily?.Value;
  }
  
  private static bool CmpPitchFamily(DXDraw.TextFontType openXmlElement, SByte? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PitchFamily?.Value == value) return true;
    diffs?.Add(objName, "PitchFamily", openXmlElement?.PitchFamily?.Value, value);
    return false;
  }
  
  private static void SetPitchFamily(DXDraw.TextFontType openXmlElement, SByte? value)
  {
    openXmlElement.PitchFamily = value;
  }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  private static SByte? GetCharacterSet(DXDraw.TextFontType openXmlElement)
  {
    return openXmlElement?.CharacterSet?.Value;
  }
  
  private static bool CmpCharacterSet(DXDraw.TextFontType openXmlElement, SByte? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CharacterSet?.Value == value) return true;
    diffs?.Add(objName, "CharacterSet", openXmlElement?.CharacterSet?.Value, value);
    return false;
  }
  
  private static void SetCharacterSet(DXDraw.TextFontType openXmlElement, SByte? value)
  {
    openXmlElement.CharacterSet = value;
  }
  
  public static DocumentModel.Drawings.TextFontType? CreateModelElement(DXDraw.TextFontType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TextFontType();
      value.Typeface = GetTypeface(openXmlElement);
      value.Panose = GetPanose(openXmlElement);
      value.PitchFamily = GetPitchFamily(openXmlElement);
      value.CharacterSet = GetCharacterSet(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.TextFontType? openXmlElement, DMDraws.TextFontType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTypeface(openXmlElement, value.Typeface, diffs, objName))
        ok = false;
      if (!CmpPanose(openXmlElement, value.Panose, diffs, objName))
        ok = false;
      if (!CmpPitchFamily(openXmlElement, value.PitchFamily, diffs, objName))
        ok = false;
      if (!CmpCharacterSet(openXmlElement, value.CharacterSet, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TextFontType value)
    where OpenXmlElementType: DXDraw.TextFontType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.TextFontType openXmlElement, DMDraws.TextFontType value)
  {
    SetTypeface(openXmlElement, value?.Typeface);
    SetPanose(openXmlElement, value?.Panose);
    SetPitchFamily(openXmlElement, value?.PitchFamily);
    SetCharacterSet(openXmlElement, value?.CharacterSet);
  }
}
