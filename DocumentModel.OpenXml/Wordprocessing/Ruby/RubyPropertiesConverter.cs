namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.RubyProperties"/> from/to OpenXml converter.
/// </summary>
public static class RubyPropertiesConverter
{
  #region RubyAlign conversion.
  private static DMW.RubyAlignKind? GetRubyAlign(DXW.RubyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.RubyAlignValues, DMW.RubyAlignKind>(openXmlElement.GetFirstChild<DXW.RubyAlign>()?.Val?.Value);
  }

  private static bool CmpRubyAlign(DXW.RubyProperties openXmlElement, DMW.RubyAlignKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.RubyAlignValues, DMW.RubyAlignKind>(openXmlElement.GetFirstChild<DXW.RubyAlign>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetRubyAlign(DXW.RubyProperties openXmlElement, DMW.RubyAlignKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyAlign>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.RubyAlignValues, DMW.RubyAlignKind>(itemElement, (DMW.RubyAlignKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.RubyAlign, DXW.RubyAlignValues, DMW.RubyAlignKind>((DMW.RubyAlignKind)value));
  }
  #endregion

  #region Phonetic Guide Text Font Size conversion.
  private static Hps? GetPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.PhoneticGuideTextFontSize>()?.Val);
  }

  private static bool CmpPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement, Hps? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.PhoneticGuideTextFontSize>()?.Val, value, diffs, objName, "PhoneticGuideTextFontSize");
  }

  private static void SetPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement, Hps? value)
  {
    StringValueConverter.SetValue<DXW.PhoneticGuideTextFontSize>(openXmlElement, value);
  }
  #endregion

  #region Distance Between Phonetic Guide Text and Phonetic Guide Base Text conversion.
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
    SimpleValueConverter.SetValue<DXW.PhoneticGuideRaise, System.Int16>(openXmlElement, value);
  }
  #endregion

  #region Phonetic Guide Base Text Font Size conversion.
  private static Hps? GetPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.PhoneticGuideBaseTextSize>()?.Val);
  }

  private static bool CmpPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.PhoneticGuideBaseTextSize>()?.Val, value, diffs, objName, "PhoneticGuideBaseTextSize");
  }

  private static void SetPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.PhoneticGuideBaseTextSize>(openXmlElement, value);
  }
  #endregion

  #region Language ID for Phonetic Guide conversion.
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
  #endregion

  #region Invalidated Field Cache conversion.
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
    BooleanValueConverter.SetOnOffType<DXW.Dirty>(openXmlElement, value, "0", null);
  }
  #endregion

  #region RubyProperties model conversion.
  public static DMW.RubyProperties? CreateModelElement(DXW.RubyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RubyProperties();
      model.RubyAlign = GetRubyAlign(openXmlElement);
      model.PhoneticGuideTextFontSize = GetPhoneticGuideTextFontSize(openXmlElement);
      model.PhoneticGuideRaise = GetPhoneticGuideRaise(openXmlElement);
      model.PhoneticGuideBaseTextSize = GetPhoneticGuideBaseTextSize(openXmlElement);
      model.LanguageId = GetLanguageId(openXmlElement);
      model.Dirty = GetDirty(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.RubyProperties? openXmlElement, DMW.RubyProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpRubyAlign(openXmlElement, model.RubyAlign, diffs, objName))
        ok = false;
      if (!CmpPhoneticGuideTextFontSize(openXmlElement, model.PhoneticGuideTextFontSize, diffs, objName))
        ok = false;
      if (!CmpPhoneticGuideRaise(openXmlElement, model.PhoneticGuideRaise, diffs, objName))
        ok = false;
      if (!CmpPhoneticGuideBaseTextSize(openXmlElement, model.PhoneticGuideBaseTextSize, diffs, objName))
        ok = false;
      if (!CmpLanguageId(openXmlElement, model.LanguageId, diffs, objName))
        ok = false;
      if (!CmpDirty(openXmlElement, model.Dirty, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RubyProperties model)
    where OpenXmlElementType : DXW.RubyProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.RubyProperties openXmlElement, DMW.RubyProperties model)
  {
    SetRubyAlign(openXmlElement, model?.RubyAlign);
    SetPhoneticGuideTextFontSize(openXmlElement, model?.PhoneticGuideTextFontSize);
    SetPhoneticGuideRaise(openXmlElement, model?.PhoneticGuideRaise);
    SetPhoneticGuideBaseTextSize(openXmlElement, model?.PhoneticGuideBaseTextSize);
    SetLanguageId(openXmlElement, model?.LanguageId);
    SetDirty(openXmlElement, model?.Dirty);
  }
  #endregion
}
