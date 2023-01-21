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
    return openXmlElement.LevelIndex?.Value;
  }
  
  private static void SetLevelIndex(DXW.Level openXmlElement, Int32? value)
  {
    openXmlElement.LevelIndex = value;
  }
  
  /// <summary>
  /// Template Code
  /// </summary>
  private static UInt32? GetTemplateCode(DXW.Level openXmlElement)
  {
    if (openXmlElement.TemplateCode?.Value != null)
      return UInt32.Parse(openXmlElement.TemplateCode.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetTemplateCode(DXW.Level openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.TemplateCode = ((UInt32)value).ToString("X8");
      else
        openXmlElement.TemplateCode = null;
  }
  
  /// <summary>
  /// Tentative Numbering
  /// </summary>
  private static Boolean? GetTentative(DXW.Level openXmlElement)
  {
    return openXmlElement?.Tentative?.Value;
  }
  
  private static void SetTentative(DXW.Level openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Tentative = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Tentative = null;
  }
  
  /// <summary>
  /// Starting Value.
  /// </summary>
  private static Int32? GetStartNumberingValue(DXW.Level openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StartNumberingValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetStartNumberingValue(DXW.Level openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StartNumberingValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.StartNumberingValue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Format.
  /// </summary>
  private static DMW.NumberingFormat? GetNumberingFormat(DXW.Level openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.NumberingFormat>();
    if (itemElement != null)
      return DMXW.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.LevelRestart>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLevelRestart(DXW.Level openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelRestart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.LevelRestart{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Paragraph Style's Associated Numbering Level.
  /// </summary>
  private static String? GetParagraphStyleIdInLevel(DXW.Level openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ParagraphStyleIdInLevel>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetParagraphStyleIdInLevel(DXW.Level openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphStyleIdInLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ParagraphStyleIdInLevel { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Display All Levels Using Arabic Numerals.
  /// </summary>
  private static Boolean? GetIsLegalNumberingStyle(DXW.Level openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.IsLegalNumberingStyle>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetIsLegalNumberingStyle(DXW.Level openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.IsLegalNumberingStyle>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.IsLegalNumberingStyle();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  private static DMW.LevelSuffixKind? GetLevelSuffix(DXW.Level openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelSuffix>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DMW.LevelSuffixKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLevelSuffix(DXW.Level openXmlElement, DMW.LevelSuffixKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelSuffix>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.LevelSuffix, DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DMW.LevelSuffixKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Level Text.
  /// </summary>
  private static DMW.LevelText? GetLevelText(DXW.Level openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LevelText>();
    if (itemElement != null)
      return DMXW.LevelTextConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.LevelPictureBulletId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLevelPictureBulletId(DXW.Level openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelPictureBulletId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.LevelPictureBulletId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Legacy Numbering Level Properties.
  /// </summary>
  private static DMW.LegacyNumbering? GetLegacyNumbering(DXW.Level openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LegacyNumbering>();
    if (itemElement != null)
      return DMXW.LegacyNumberingConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DMW.LevelJustificationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLevelJustification(DXW.Level openXmlElement, DMW.LevelJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LevelJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.LevelJustification, DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DMW.LevelJustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Level Associated Paragraph Properties.
  /// </summary>
  private static DMW.PreviousParagraphProperties? GetPreviousParagraphProperties(DXW.Level openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PreviousParagraphProperties>();
    if (itemElement != null)
      return DMXW.PreviousParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.NumberingSymbolRunProperties>();
    if (itemElement != null)
      return DMXW.NumberingSymbolRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.Level? CreateModelElement(DXW.Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Level();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Level? value)
    where OpenXmlElementType: DXW.Level, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
