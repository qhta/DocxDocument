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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>(openXmlElement.GetFirstChild<DXW.RubyAlign>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRubyAlign(DXW.RubyProperties openXmlElement, DMW.RubyAlignKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyAlign>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.RubyAlign, DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  private static String? GetPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.PhoneticGuideTextFontSize>()?.Val?.Value;
  }
  
  private static bool CmpPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.PhoneticGuideTextFontSize>()?.Val?.Value == value;
  }
  
  private static void SetPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PhoneticGuideTextFontSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.PhoneticGuideTextFontSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  private static Int16? GetPhoneticGuideRaise(DXW.RubyProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.PhoneticGuideRaise>()?.Val?.Value;
  }
  
  private static bool CmpPhoneticGuideRaise(DXW.RubyProperties openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PhoneticGuideRaise>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.PhoneticGuideRaise", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetPhoneticGuideRaise(DXW.RubyProperties openXmlElement, Int16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PhoneticGuideRaise>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.PhoneticGuideRaise{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  private static String? GetPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.PhoneticGuideBaseTextSize>()?.Val?.Value;
  }
  
  private static bool CmpPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.PhoneticGuideBaseTextSize>()?.Val?.Value == value;
  }
  
  private static void SetPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PhoneticGuideBaseTextSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.PhoneticGuideBaseTextSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  private static String? GetLanguageId(DXW.RubyProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.LanguageId>()?.Val?.Value;
  }
  
  private static bool CmpLanguageId(DXW.RubyProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.LanguageId>()?.Val?.Value == value;
  }
  
  private static void SetLanguageId(DXW.RubyProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LanguageId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.LanguageId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  private static Boolean? GetDirty(DXW.RubyProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.Dirty>()?.Val?.Value;
  }
  
  private static bool CmpDirty(DXW.RubyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.Dirty>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Dirty", val, value);
    return false;
  }
  
  private static void SetDirty(DXW.RubyProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Dirty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Dirty();
      openXmlElement.AddChild(itemElement);
    }
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RubyProperties? value)
    where OpenXmlElementType: DXW.RubyProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRubyAlign(openXmlElement, value?.RubyAlign);
      SetPhoneticGuideTextFontSize(openXmlElement, value?.PhoneticGuideTextFontSize);
      SetPhoneticGuideRaise(openXmlElement, value?.PhoneticGuideRaise);
      SetPhoneticGuideBaseTextSize(openXmlElement, value?.PhoneticGuideBaseTextSize);
      SetLanguageId(openXmlElement, value?.LanguageId);
      SetDirty(openXmlElement, value?.Dirty);
      return openXmlElement;
    }
    return default;
  }
}
