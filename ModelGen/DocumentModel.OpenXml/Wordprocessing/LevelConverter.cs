namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Level Definition.
/// </summary>
public static class LevelConverter
{
  /// <summary>
  /// Numbering Level
  /// </summary>
  private static Int32? GetLevelIndex(DXW.Level openXmlElement)
  {
    return openXmlElement?.LevelIndex?.Value;
  }
  
  private static bool CmpLevelIndex(DXW.Level openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LevelIndex?.Value == value) return true;
    diffs?.Add(objName, "LevelIndex", openXmlElement?.LevelIndex?.Value, value);
    return false;
  }
  
  private static void SetLevelIndex(DXW.Level openXmlElement, Int32? value)
  {
    openXmlElement.LevelIndex = value;
  }
  
  /// <summary>
  /// Template Code
  /// </summary>
  private static DM.HexInt? GetTemplateCode(DXW.Level openXmlElement)
  {
    if (openXmlElement?.TemplateCode?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.TemplateCode.Value);
    return null;
  }
  
  private static bool CmpTemplateCode(DXW.Level openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
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
  
  /// <summary>
  /// Tentative Numbering
  /// </summary>
  private static Boolean? GetTentative(DXW.Level openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Tentative);
  }
  
  private static bool CmpTentative(DXW.Level openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Tentative, value, diffs, objName, "Tentative");
  }
  
  private static void SetTentative(DXW.Level openXmlElement, Boolean? value)
  {
    openXmlElement.Tentative = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Starting Value.
  /// </summary>
  private static Int32? GetStartNumberingValue(DXW.Level openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.StartNumberingValue>()?.Val);
  }
  
  private static bool CmpStartNumberingValue(DXW.Level openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.StartNumberingValue>()?.Val, value, diffs, objName, "StartNumberingValue");
  }
  
  private static void SetStartNumberingValue(DXW.Level openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.StartNumberingValue,System.Int32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Numbering Format.
  /// </summary>
  private static DMW.NumberingFormat? GetNumberingFormat(DXW.Level openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingFormat>();
    if (element != null)
      return DMXW.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXW.Level openXmlElement, DMW.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Restart Numbering Level Symbol.
  /// </summary>
  private static Int32? GetLevelRestart(DXW.Level openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.LevelRestart>()?.Val);
  }
  
  private static bool CmpLevelRestart(DXW.Level openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.LevelRestart>()?.Val, value, diffs, objName, "LevelRestart");
  }
  
  private static void SetLevelRestart(DXW.Level openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.LevelRestart,System.Int32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Paragraph Style's Associated Numbering Level.
  /// </summary>
  private static String? GetParagraphStyleIdInLevel(DXW.Level openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.ParagraphStyleIdInLevel>()?.Val);
  }
  
  private static bool CmpParagraphStyleIdInLevel(DXW.Level openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.ParagraphStyleIdInLevel>()?.Val, value, diffs, objName, "ParagraphStyleIdInLevel");
  }
  
  private static void SetParagraphStyleIdInLevel(DXW.Level openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.ParagraphStyleIdInLevel>(openXmlElement, value);
  }
  
  /// <summary>
  /// Display All Levels Using Arabic Numerals.
  /// </summary>
  private static Boolean? GetIsLegalNumberingStyle(DXW.Level openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.IsLegalNumberingStyle>());
  }
  
  private static bool CmpIsLegalNumberingStyle(DXW.Level openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.IsLegalNumberingStyle>(), value, diffs, objName);
  }
  
  private static void SetIsLegalNumberingStyle(DXW.Level openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.IsLegalNumberingStyle>(openXmlElement, value);
  }
  
  /// <summary>
  /// Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  private static DMW.LevelSuffixKind? GetLevelSuffix(DXW.Level openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DMW.LevelSuffixKind>(openXmlElement.GetFirstChild<DXW.LevelSuffix>()?.Val?.Value);
  }
  
  private static bool CmpLevelSuffix(DXW.Level openXmlElement, DMW.LevelSuffixKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DMW.LevelSuffixKind>(openXmlElement.GetFirstChild<DXW.LevelSuffix>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLevelSuffix(DXW.Level openXmlElement, DMW.LevelSuffixKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelSuffix>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DMW.LevelSuffixKind>(itemElement, (DMW.LevelSuffixKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.LevelSuffix, DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DMW.LevelSuffixKind>((DMW.LevelSuffixKind)value));
  }
  
  /// <summary>
  /// Numbering Level Text.
  /// </summary>
  private static DMW.LevelText? GetLevelText(DXW.Level openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LevelText>();
    if (element != null)
      return DMXW.LevelTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevelText(DXW.Level openXmlElement, DMW.LevelText? value, DiffList? diffs, string? objName)
  {
    return DMXW.LevelTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LevelText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLevelText(DXW.Level openXmlElement, DMW.LevelText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LevelTextConverter.CreateOpenXmlElement<DXW.LevelText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Numbering Symbol Definition Reference.
  /// </summary>
  private static Int32? GetLevelPictureBulletId(DXW.Level openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.LevelPictureBulletId>()?.Val);
  }
  
  private static bool CmpLevelPictureBulletId(DXW.Level openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.LevelPictureBulletId>()?.Val, value, diffs, objName, "LevelPictureBulletId");
  }
  
  private static void SetLevelPictureBulletId(DXW.Level openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.LevelPictureBulletId,System.Int32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Legacy Numbering Level Properties.
  /// </summary>
  private static DMW.LegacyNumbering? GetLegacyNumbering(DXW.Level openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LegacyNumbering>();
    if (element != null)
      return DMXW.LegacyNumberingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLegacyNumbering(DXW.Level openXmlElement, DMW.LegacyNumbering? value, DiffList? diffs, string? objName)
  {
    return DMXW.LegacyNumberingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LegacyNumbering>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  private static DMW.LevelJustificationKind? GetLevelJustification(DXW.Level openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DMW.LevelJustificationKind>(openXmlElement.GetFirstChild<DXW.LevelJustification>()?.Val?.Value);
  }
  
  private static bool CmpLevelJustification(DXW.Level openXmlElement, DMW.LevelJustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DMW.LevelJustificationKind>(openXmlElement.GetFirstChild<DXW.LevelJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLevelJustification(DXW.Level openXmlElement, DMW.LevelJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DMW.LevelJustificationKind>(itemElement, (DMW.LevelJustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.LevelJustification, DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DMW.LevelJustificationKind>((DMW.LevelJustificationKind)value));
  }
  
  /// <summary>
  /// Numbering Level Associated Paragraph Properties.
  /// </summary>
  private static DMW.PreviousParagraphProperties? GetPreviousParagraphProperties(DXW.Level openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousParagraphProperties>();
    if (element != null)
      return DMXW.PreviousParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousParagraphProperties(DXW.Level openXmlElement, DMW.PreviousParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Symbol Run Properties.
  /// </summary>
  private static DMW.NumberingSymbolRunProperties? GetNumberingSymbolRunProperties(DXW.Level openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingSymbolRunProperties>();
    if (element != null)
      return DMXW.NumberingSymbolRunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingSymbolRunProperties(DXW.Level openXmlElement, DMW.NumberingSymbolRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingSymbolRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingSymbolRunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Level? CreateModelElement(DXW.Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Level();
      value.LevelIndex = GetLevelIndex(openXmlElement);
      value.TemplateCode = GetTemplateCode(openXmlElement);
      value.Tentative = GetTentative(openXmlElement);
      value.StartNumberingValue = GetStartNumberingValue(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.LevelRestart = GetLevelRestart(openXmlElement);
      value.ParagraphStyleIdInLevel = GetParagraphStyleIdInLevel(openXmlElement);
      value.IsLegalNumberingStyle = GetIsLegalNumberingStyle(openXmlElement);
      value.LevelSuffix = GetLevelSuffix(openXmlElement);
      value.LevelText = GetLevelText(openXmlElement);
      value.LevelPictureBulletId = GetLevelPictureBulletId(openXmlElement);
      value.LegacyNumbering = GetLegacyNumbering(openXmlElement);
      value.LevelJustification = GetLevelJustification(openXmlElement);
      value.PreviousParagraphProperties = GetPreviousParagraphProperties(openXmlElement);
      value.NumberingSymbolRunProperties = GetNumberingSymbolRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Level? openXmlElement, DMW.Level? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLevelIndex(openXmlElement, value.LevelIndex, diffs, objName))
        ok = false;
      if (!CmpTemplateCode(openXmlElement, value.TemplateCode, diffs, objName))
        ok = false;
      if (!CmpTentative(openXmlElement, value.Tentative, diffs, objName))
        ok = false;
      if (!CmpStartNumberingValue(openXmlElement, value.StartNumberingValue, diffs, objName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName))
        ok = false;
      if (!CmpLevelRestart(openXmlElement, value.LevelRestart, diffs, objName))
        ok = false;
      if (!CmpParagraphStyleIdInLevel(openXmlElement, value.ParagraphStyleIdInLevel, diffs, objName))
        ok = false;
      if (!CmpIsLegalNumberingStyle(openXmlElement, value.IsLegalNumberingStyle, diffs, objName))
        ok = false;
      if (!CmpLevelSuffix(openXmlElement, value.LevelSuffix, diffs, objName))
        ok = false;
      if (!CmpLevelText(openXmlElement, value.LevelText, diffs, objName))
        ok = false;
      if (!CmpLevelPictureBulletId(openXmlElement, value.LevelPictureBulletId, diffs, objName))
        ok = false;
      if (!CmpLegacyNumbering(openXmlElement, value.LegacyNumbering, diffs, objName))
        ok = false;
      if (!CmpLevelJustification(openXmlElement, value.LevelJustification, diffs, objName))
        ok = false;
      if (!CmpPreviousParagraphProperties(openXmlElement, value.PreviousParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpNumberingSymbolRunProperties(openXmlElement, value.NumberingSymbolRunProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Level value)
    where OpenXmlElementType: DXW.Level, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Level openXmlElement, DMW.Level value)
  {
    SetLevelIndex(openXmlElement, value?.LevelIndex);
    SetTemplateCode(openXmlElement, value?.TemplateCode);
    SetTentative(openXmlElement, value?.Tentative);
    SetStartNumberingValue(openXmlElement, value?.StartNumberingValue);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
    SetLevelRestart(openXmlElement, value?.LevelRestart);
    SetParagraphStyleIdInLevel(openXmlElement, value?.ParagraphStyleIdInLevel);
    SetIsLegalNumberingStyle(openXmlElement, value?.IsLegalNumberingStyle);
    SetLevelSuffix(openXmlElement, value?.LevelSuffix);
    SetLevelText(openXmlElement, value?.LevelText);
    SetLevelPictureBulletId(openXmlElement, value?.LevelPictureBulletId);
    SetLegacyNumbering(openXmlElement, value?.LegacyNumbering);
    SetLevelJustification(openXmlElement, value?.LevelJustification);
    SetPreviousParagraphProperties(openXmlElement, value?.PreviousParagraphProperties);
    SetNumberingSymbolRunProperties(openXmlElement, value?.NumberingSymbolRunProperties);
  }
}
