namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextFontType Class.
/// </summary>
public static class TextFontTypeConverter
{
  /// <summary>
  /// Text Typeface
  /// </summary>
  private static String? GetTypeface(DXD.TextFontType openXmlElement)
  {
    return openXmlElement?.Typeface?.Value;
  }
  
  private static bool CmpTypeface(DXD.TextFontType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Typeface?.Value == value) return true;
    diffs?.Add(objName, "Typeface", openXmlElement?.Typeface?.Value, value);
    return false;
  }
  
  private static void SetTypeface(DXD.TextFontType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Typeface = new StringValue { Value = value };
    else
      openXmlElement.Typeface = null;
  }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  private static HexBinary? GetPanose(DXD.TextFontType openXmlElement)
  {
    if (openXmlElement?.Panose?.Value != null)
      return Convert.FromHexString(openXmlElement.Panose.Value);
    return null;
  }
  
  private static bool CmpPanose(DXD.TextFontType openXmlElement, HexBinary? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Panose?.Value != null && value!=null)
      if (Convert.FromHexString(openXmlElement.Panose.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.Panose?.Value == null && value == null) return true;
    diffs?.Add(objName, "Panose", openXmlElement?.Panose?.Value, value);
    return false;
  }
  
  private static void SetPanose(DXD.TextFontType openXmlElement, HexBinary? value)
  {
    if (value != null)
      openXmlElement.Panose = Convert.ToHexString(value);
    else
      openXmlElement.Panose = null;
  }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  private static SByte? GetPitchFamily(DXD.TextFontType openXmlElement)
  {
    return openXmlElement?.PitchFamily?.Value;
  }
  
  private static bool CmpPitchFamily(DXD.TextFontType openXmlElement, SByte? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.PitchFamily?.Value == value) return true;
    diffs?.Add(objName, "PitchFamily", openXmlElement?.PitchFamily?.Value, value);
    return false;
  }
  
  private static void SetPitchFamily(DXD.TextFontType openXmlElement, SByte? value)
  {
    openXmlElement.PitchFamily = value;
  }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  private static SByte? GetCharacterSet(DXD.TextFontType openXmlElement)
  {
    return openXmlElement?.CharacterSet?.Value;
  }
  
  private static bool CmpCharacterSet(DXD.TextFontType openXmlElement, SByte? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.CharacterSet?.Value == value) return true;
    diffs?.Add(objName, "CharacterSet", openXmlElement?.CharacterSet?.Value, value);
    return false;
  }
  
  private static void SetCharacterSet(DXD.TextFontType openXmlElement, SByte? value)
  {
    openXmlElement.CharacterSet = value;
  }
  
  public static DMD.TextFontType? CreateModelElement(DXD.TextFontType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.TextFontType();
      value.Typeface = GetTypeface(openXmlElement);
      value.Panose = GetPanose(openXmlElement);
      value.PitchFamily = GetPitchFamily(openXmlElement);
      value.CharacterSet = GetCharacterSet(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.TextFontType? openXmlElement, DMD.TextFontType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTypeface(openXmlElement, value.Typeface, diffs, objName, propName))
        ok = false;
      if (!CmpPanose(openXmlElement, value.Panose, diffs, objName, propName))
        ok = false;
      if (!CmpPitchFamily(openXmlElement, value.PitchFamily, diffs, objName, propName))
        ok = false;
      if (!CmpCharacterSet(openXmlElement, value.CharacterSet, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMD.TextFontType? value)
    where OpenXmlElementType: DXD.TextFontType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTypeface(openXmlElement, value?.Typeface);
      SetPanose(openXmlElement, value?.Panose);
      SetPitchFamily(openXmlElement, value?.PitchFamily);
      SetCharacterSet(openXmlElement, value?.CharacterSet);
      return openXmlElement;
    }
    return default;
  }
}
