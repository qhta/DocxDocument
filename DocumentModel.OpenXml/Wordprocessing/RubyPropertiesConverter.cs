namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Phonetic Guide Properties.
/// </summary>
public static class RubyPropertiesConverter
{
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  private static DMW.RubyAlignKind? GetRubyAlign(DXW.RubyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>(openXmlElement.GetFirstChild<DXW.RubyAlign>()?.Val?.Value);
  }
  
  private static bool CmpRubyAlign(DXW.RubyProperties openXmlElement, DMW.RubyAlignKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>(openXmlElement.GetFirstChild<DXW.RubyAlign>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetRubyAlign(DXW.RubyProperties openXmlElement, DMW.RubyAlignKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyAlign>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>(itemElement, (DMW.RubyAlignKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.RubyAlign, DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>((DMW.RubyAlignKind)value));
  }
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  private static String? GetPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.PhoneticGuideTextFontSize>()?.Val);
  }
  
  private static bool CmpPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.PhoneticGuideTextFontSize>()?.Val, value, diffs, objName, "PhoneticGuideTextFontSize");
  }
  
  private static void SetPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.PhoneticGuideTextFontSize>(openXmlElement, value);
  }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  private static Int16? GetPhoneticGuideRaise(DXW.RubyProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.PhoneticGuideRaise>()?.Val);
  }
  
  private static bool CmpPhoneticGuideRaise(DXW.RubyProperties openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.PhoneticGuideRaise>()?.Val, value, diffs, objName, "PhoneticGuideRaise");
  }
  
  private static void SetPhoneticGuideRaise(DXW.RubyProperties openXmlElement, Int16? value)
  {
    SimpleValueConverter.SetValue<DXW.PhoneticGuideRaise,System.Int16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  private static String? GetPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.PhoneticGuideBaseTextSize>()?.Val);
  }
  
  private static bool CmpPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.PhoneticGuideBaseTextSize>()?.Val, value, diffs, objName, "PhoneticGuideBaseTextSize");
  }
  
  private static void SetPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.PhoneticGuideBaseTextSize>(openXmlElement, value);
  }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  private static String? GetLanguageId(DXW.RubyProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.LanguageId>()?.Val);
  }
  
  private static bool CmpLanguageId(DXW.RubyProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.LanguageId>()?.Val, value, diffs, objName, "LanguageId");
  }
  
  private static void SetLanguageId(DXW.RubyProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.LanguageId>(openXmlElement, value);
  }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  private static Boolean? GetDirty(DXW.RubyProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Dirty>());
  }
  
  private static bool CmpDirty(DXW.RubyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Dirty>(), value, diffs, objName);
  }
  
  private static void SetDirty(DXW.RubyProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Dirty>(openXmlElement, value);
  }
  
  public static DMW.RubyProperties? CreateModelElement(DXW.RubyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RubyProperties();
      value.RubyAlign = GetRubyAlign(openXmlElement);
      value.PhoneticGuideTextFontSize = GetPhoneticGuideTextFontSize(openXmlElement);
      value.PhoneticGuideRaise = GetPhoneticGuideRaise(openXmlElement);
      value.PhoneticGuideBaseTextSize = GetPhoneticGuideBaseTextSize(openXmlElement);
      value.LanguageId = GetLanguageId(openXmlElement);
      value.Dirty = GetDirty(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.RubyProperties? openXmlElement, DMW.RubyProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRubyAlign(openXmlElement, value.RubyAlign, diffs, objName))
        ok = false;
      if (!CmpPhoneticGuideTextFontSize(openXmlElement, value.PhoneticGuideTextFontSize, diffs, objName))
        ok = false;
      if (!CmpPhoneticGuideRaise(openXmlElement, value.PhoneticGuideRaise, diffs, objName))
        ok = false;
      if (!CmpPhoneticGuideBaseTextSize(openXmlElement, value.PhoneticGuideBaseTextSize, diffs, objName))
        ok = false;
      if (!CmpLanguageId(openXmlElement, value.LanguageId, diffs, objName))
        ok = false;
      if (!CmpDirty(openXmlElement, value.Dirty, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RubyProperties value)
    where OpenXmlElementType: DXW.RubyProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.RubyProperties openXmlElement, DMW.RubyProperties value)
  {
    SetRubyAlign(openXmlElement, value?.RubyAlign);
    SetPhoneticGuideTextFontSize(openXmlElement, value?.PhoneticGuideTextFontSize);
    SetPhoneticGuideRaise(openXmlElement, value?.PhoneticGuideRaise);
    SetPhoneticGuideBaseTextSize(openXmlElement, value?.PhoneticGuideBaseTextSize);
    SetLanguageId(openXmlElement, value?.LanguageId);
    SetDirty(openXmlElement, value?.Dirty);
  }
}
