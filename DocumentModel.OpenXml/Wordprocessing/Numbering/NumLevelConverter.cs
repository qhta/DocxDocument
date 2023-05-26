namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Level Definition.
/// </summary>
public static class LevelConverter
{

  #region LevelIndex conversion.
  private static Int32? GetLevelIndex(DXW.Level openXmlElement)
  {
    return openXmlElement?.LevelIndex?.Value;
  }

  private static bool CmpLevelIndex(DXW.Level openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.LevelIndex?.Value == value) return true;
    diffs?.Add(objName, "LevelIndex", openXmlElement?.LevelIndex?.Value, value);
    return false;
  }

  private static void SetLevelIndex(DXW.Level openXmlElement, Int32? value)
  {
    openXmlElement.LevelIndex = value;
  }
  #endregion

  #region TemplateCode conversion.
  private static DM.HexInt? GetTemplateCode(DXW.Level openXmlElement)
  {
    if (openXmlElement?.TemplateCode?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.TemplateCode.Value);
    return null;
  }

  private static bool CmpTemplateCode(DXW.Level openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.TemplateCode?.Value, value, diffs, objName, "TemplateCode");
  }

  private static void SetTemplateCode(DXW.Level openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.TemplateCode = value.ToString();
    else
      openXmlElement.TemplateCode = null;
  }
  #endregion

  #region Tentative conversion.
  private static Boolean? GetTentative(DXW.Level openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Tentative);
  }

  private static bool CmpTentative(DXW.Level openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Tentative, value, diffs, objName, "Tentative");
  }

  private static void SetTentative(DXW.Level openXmlElement, Boolean? value)
  {
    openXmlElement.Tentative = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region StartNumbering conversion.
  private static Int32? GetStartNumberingValue(DXW.Level openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.StartNumberingValue>()?.Val);
  }

  private static bool CmpStartNumberingValue(DXW.Level openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.StartNumberingValue>()?.Val, value, diffs, objName, "StartNumberingValue");
  }

  private static void SetStartNumberingValue(DXW.Level openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.StartNumberingValue, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region NumberingFormat conversion.
  private static DMW.NumberingFormat? GetNumberingFormat(DXW.Level openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingFormat>();
    if (element != null)
      return DMXW.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpNumberingFormat(DXW.Level openXmlElement, DMW.NumberingFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingFormat>(), value, diffs, objName, propName);
  }

  private static void SetNumberingFormat(DXW.Level openXmlElement, DMW.NumberingFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NumberingFormatConverter.CreateOpenXmlElement<DXW.NumberingFormat>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region LevelRestart conversion.
  private static Int32? GetLevelRestart(DXW.Level openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.LevelRestart>()?.Val);
  }

  private static bool CmpLevelRestart(DXW.Level openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.LevelRestart>()?.Val, value, diffs, objName, "LevelRestart");
  }

  private static void SetLevelRestart(DXW.Level openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.LevelRestart, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region ParagraphStyleIdInLevel conversion.
  private static String? GetParagraphStyleIdInLevel(DXW.Level openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.ParagraphStyleIdInLevel>()?.Val);
  }

  private static bool CmpParagraphStyleIdInLevel(DXW.Level openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.ParagraphStyleIdInLevel>()?.Val, value, diffs, objName, "ParagraphStyleIdInLevel");
  }

  private static void SetParagraphStyleIdInLevel(DXW.Level openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.ParagraphStyleIdInLevel>(openXmlElement, value);
  }
  #endregion

  #region IsLegalNumberingStyle conversion.
  private static Boolean? GetIsLegalNumberingStyle(DXW.Level openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.IsLegalNumberingStyle>());
  }

  private static bool CmpIsLegalNumberingStyle(DXW.Level openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.IsLegalNumberingStyle>(), value, diffs, objName, propName);
  }

  private static void SetIsLegalNumberingStyle(DXW.Level openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.IsLegalNumberingStyle>(openXmlElement, value, "0", null);
  }
  #endregion

  #region LevelSuffix conversion.
  private static DMW.LevelSuffixKind? GetLevelSuffix(DXW.Level openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.LevelSuffixValues, DMW.LevelSuffixKind>(openXmlElement.GetFirstChild<DXW.LevelSuffix>()?.Val?.Value);
  }

  private static bool CmpLevelSuffix(DXW.Level openXmlElement, DMW.LevelSuffixKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.LevelSuffixValues, DMW.LevelSuffixKind>(openXmlElement.GetFirstChild<DXW.LevelSuffix>()?.Val?.Value, value, diffs, objName, propName);
  }

  private static void SetLevelSuffix(DXW.Level openXmlElement, DMW.LevelSuffixKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelSuffix>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.LevelSuffixValues, DMW.LevelSuffixKind>(itemElement, (DMW.LevelSuffixKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.LevelSuffix, DXW.LevelSuffixValues, DMW.LevelSuffixKind>((DMW.LevelSuffixKind)value));
  }
  #endregion

  #region LevelText conversion.
  private static DMW.NumLevelText? GetLevelText(DXW.Level openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LevelText>();
    if (element != null)
      return DMXW.LevelTextConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpLevelText(DXW.Level openXmlElement, DMW.NumLevelText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.LevelTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LevelText>(), value, diffs, objName, propName);
  }

  private static void SetLevelText(DXW.Level openXmlElement, DMW.NumLevelText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LevelTextConverter.CreateOpenXmlElement<DXW.LevelText>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region LevelPictureBulletId conversion.
  private static Int32? GetLevelPictureBulletId(DXW.Level openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.LevelPictureBulletId>()?.Val);
  }

  private static bool CmpLevelPictureBulletId(DXW.Level openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.LevelPictureBulletId>()?.Val, value, diffs, objName, "LevelPictureBulletId");
  }

  private static void SetLevelPictureBulletId(DXW.Level openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.LevelPictureBulletId, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region LegacyNumbering conversion.
  private static DMW.LegacyNumbering? GetLegacyNumbering(DXW.Level openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LegacyNumbering>();
    if (element != null)
      return DMXW.LegacyNumberingConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpLegacyNumbering(DXW.Level openXmlElement, DMW.LegacyNumbering? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.LegacyNumberingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LegacyNumbering>(), value, diffs, objName, propName);
  }

  private static void SetLegacyNumbering(DXW.Level openXmlElement, DMW.LegacyNumbering? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LegacyNumbering>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LegacyNumberingConverter.CreateOpenXmlElement<DXW.LegacyNumbering>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region LevelJustification conversion.
  private static DMW.LevelJustificationKind? GetLevelJustification(DXW.Level openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.LevelJustificationValues, DMW.LevelJustificationKind>(openXmlElement.GetFirstChild<DXW.LevelJustification>()?.Val?.Value);
  }

  private static bool CmpLevelJustification(DXW.Level openXmlElement, DMW.LevelJustificationKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.LevelJustificationValues, DMW.LevelJustificationKind>(openXmlElement.GetFirstChild<DXW.LevelJustification>()?.Val?.Value, value, diffs, objName, propName);
  }

  private static void SetLevelJustification(DXW.Level openXmlElement, DMW.LevelJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.LevelJustificationValues, DMW.LevelJustificationKind>(itemElement, (DMW.LevelJustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.LevelJustification, DXW.LevelJustificationValues, DMW.LevelJustificationKind>((DMW.LevelJustificationKind)value));
  }
  #endregion

  #region PreviousParagraphProperties conversion.
  private static DMW.PreviousParagraphProperties? GetPreviousParagraphProperties(DXW.Level openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousParagraphProperties>();
    if (element != null)
      return DMXW.PreviousParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpPreviousParagraphProperties(DXW.Level openXmlElement, DMW.PreviousParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.PreviousParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousParagraphProperties>(), value, diffs, objName, propName);
  }

  private static void SetPreviousParagraphProperties(DXW.Level openXmlElement, DMW.PreviousParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousParagraphPropertiesConverter.CreateOpenXmlElement<DXW.PreviousParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region NumberingSymbolRunProperties conversion.
  private static DMW.NumberingSymbolRunProperties? GetNumberingSymbolRunProperties(DXW.Level openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingSymbolRunProperties>();
    if (element != null)
      return DMXW.NumberingSymbolRunPropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpNumberingSymbolRunProperties(DXW.Level openXmlElement, DMW.NumberingSymbolRunProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.NumberingSymbolRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingSymbolRunProperties>(), value, diffs, objName, propName);
  }

  private static void SetNumberingSymbolRunProperties(DXW.Level openXmlElement, DMW.NumberingSymbolRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingSymbolRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NumberingSymbolRunPropertiesConverter.CreateOpenXmlElement<DXW.NumberingSymbolRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region NumLevel model conversion
  public static DMW.NumLevel? CreateModelElement(DXW.Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.NumLevel();
      model.LevelIndex = GetLevelIndex(openXmlElement);
      model.TemplateCode = GetTemplateCode(openXmlElement);
      model.Tentative = GetTentative(openXmlElement);
      model.StartNumberingValue = GetStartNumberingValue(openXmlElement);
      model.NumberingFormat = GetNumberingFormat(openXmlElement);
      model.LevelRestart = GetLevelRestart(openXmlElement);
      model.ParagraphStyleIdInLevel = GetParagraphStyleIdInLevel(openXmlElement);
      model.IsLegalNumberingStyle = GetIsLegalNumberingStyle(openXmlElement);
      model.LevelSuffix = GetLevelSuffix(openXmlElement);
      model.LevelText = GetLevelText(openXmlElement);
      model.LevelPictureBulletId = GetLevelPictureBulletId(openXmlElement);
      model.LegacyNumbering = GetLegacyNumbering(openXmlElement);
      model.LevelJustification = GetLevelJustification(openXmlElement);
      model.NumberingLevelParagraphProperties = GetPreviousParagraphProperties(openXmlElement);
      model.NumberingSymbolRunProperties = GetNumberingSymbolRunProperties(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Level? openXmlElement, DMW.NumLevel? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpLevelIndex(openXmlElement, model.LevelIndex, diffs, objName, propName))
        ok = false;
      if (!CmpTemplateCode(openXmlElement, model.TemplateCode, diffs, objName, propName))
        ok = false;
      if (!CmpTentative(openXmlElement, model.Tentative, diffs, objName, propName))
        ok = false;
      if (!CmpStartNumberingValue(openXmlElement, model.StartNumberingValue, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, model.NumberingFormat, diffs, objName, propName))
        ok = false;
      if (!CmpLevelRestart(openXmlElement, model.LevelRestart, diffs, objName, propName))
        ok = false;
      if (!CmpParagraphStyleIdInLevel(openXmlElement, model.ParagraphStyleIdInLevel, diffs, objName, propName))
        ok = false;
      if (!CmpIsLegalNumberingStyle(openXmlElement, model.IsLegalNumberingStyle, diffs, objName, propName))
        ok = false;
      if (!CmpLevelSuffix(openXmlElement, model.LevelSuffix, diffs, objName, propName))
        ok = false;
      if (!CmpLevelText(openXmlElement, model.LevelText, diffs, objName, propName))
        ok = false;
      if (!CmpLevelPictureBulletId(openXmlElement, model.LevelPictureBulletId, diffs, objName, propName))
        ok = false;
      if (!CmpLegacyNumbering(openXmlElement, model.LegacyNumbering, diffs, objName, propName))
        ok = false;
      if (!CmpLevelJustification(openXmlElement, model.LevelJustification, diffs, objName, propName))
        ok = false;
      if (!CmpPreviousParagraphProperties(openXmlElement, model.NumberingLevelParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingSymbolRunProperties(openXmlElement, model.NumberingSymbolRunProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumLevel model)
    where OpenXmlElementType : DXW.Level, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Level openXmlElement, DMW.NumLevel model)
  {
    SetLevelIndex(openXmlElement, model?.LevelIndex);
    SetTemplateCode(openXmlElement, model?.TemplateCode);
    SetTentative(openXmlElement, model?.Tentative);
    SetStartNumberingValue(openXmlElement, model?.StartNumberingValue);
    SetNumberingFormat(openXmlElement, model?.NumberingFormat);
    SetLevelRestart(openXmlElement, model?.LevelRestart);
    SetParagraphStyleIdInLevel(openXmlElement, model?.ParagraphStyleIdInLevel);
    SetIsLegalNumberingStyle(openXmlElement, model?.IsLegalNumberingStyle);
    SetLevelSuffix(openXmlElement, model?.LevelSuffix);
    SetLevelText(openXmlElement, model?.LevelText);
    SetLevelPictureBulletId(openXmlElement, model?.LevelPictureBulletId);
    SetLegacyNumbering(openXmlElement, model?.LegacyNumbering);
    SetLevelJustification(openXmlElement, model?.LevelJustification);
    SetPreviousParagraphProperties(openXmlElement, model?.NumberingLevelParagraphProperties);
    SetNumberingSymbolRunProperties(openXmlElement, model?.NumberingSymbolRunProperties);
  }
  #endregion

}