using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using LegacyNumbering = DocumentModel.Wordprocessing.LegacyNumbering;
using Level = DocumentFormat.OpenXml.Wordprocessing.Level;
using LevelText = DocumentModel.Wordprocessing.LevelText;
using NumberingFormat = DocumentModel.Wordprocessing.NumberingFormat;
using NumberingSymbolRunProperties = DocumentModel.Wordprocessing.NumberingSymbolRunProperties;
using PreviousParagraphProperties = DocumentModel.Wordprocessing.PreviousParagraphProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Numbering Level Definition.
/// </summary>
public static class LevelConverter
{
  /// <summary>
  ///   Numbering Level
  /// </summary>
  public static Int32? GetLevelIndex(Level? openXmlElement)
  {
    return openXmlElement?.LevelIndex?.Value;
  }

  public static void SetLevelIndex(Level? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LevelIndex = value;
  }

  /// <summary>
  ///   Template Code
  /// </summary>
  public static Byte[]? GetTemplateCode(Level? openXmlElement)
  {
    if (openXmlElement?.TemplateCode?.Value != null)
      return Convert.FromHexString(openXmlElement.TemplateCode.Value);
    return null;
  }

  public static void SetTemplateCode(Level? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.TemplateCode = Convert.ToHexString(value);
      else
        openXmlElement.TemplateCode = null;
    }
  }

  /// <summary>
  ///   Tentative Numbering
  /// </summary>
  public static Boolean? GetTentative(Level? openXmlElement)
  {
    return openXmlElement?.Tentative?.Value;
  }

  public static void SetTentative(Level? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tentative = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Tentative = null;
  }

  /// <summary>
  ///   Starting Value.
  /// </summary>
  public static Int32? GetStartNumberingValue(Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StartNumberingValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetStartNumberingValue(Level? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StartNumberingValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new StartNumberingValue { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Numbering Format.
  /// </summary>
  public static NumberingFormat? GetNumberingFormat(Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(Level? openXmlElement, NumberingFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Restart Numbering Level Symbol.
  /// </summary>
  public static Int32? GetLevelRestart(Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LevelRestart>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLevelRestart(Level? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LevelRestart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LevelRestart { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Paragraph Style's Associated Numbering Level.
  /// </summary>
  public static String? GetParagraphStyleIdInLevel(Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ParagraphStyleIdInLevel>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetParagraphStyleIdInLevel(Level? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ParagraphStyleIdInLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ParagraphStyleIdInLevel { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Display All Levels Using Arabic Numerals.
  /// </summary>
  public static Boolean? GetIsLegalNumberingStyle(Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<IsLegalNumberingStyle>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetIsLegalNumberingStyle(Level? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<IsLegalNumberingStyle>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new IsLegalNumberingStyle();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  public static LevelSuffixKind? GetLevelSuffix(Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LevelSuffix>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LevelSuffixValues, LevelSuffixKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLevelSuffix(Level? openXmlElement, LevelSuffixKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LevelSuffix>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<LevelSuffix, LevelSuffixValues, LevelSuffixKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Numbering Level Text.
  /// </summary>
  public static LevelText? GetLevelText(Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelText>();
    if (itemElement != null)
      return LevelTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevelText(Level? openXmlElement, LevelText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LevelTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Picture Numbering Symbol Definition Reference.
  /// </summary>
  public static Int32? GetLevelPictureBulletId(Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LevelPictureBulletId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLevelPictureBulletId(Level? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LevelPictureBulletId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LevelPictureBulletId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Legacy Numbering Level Properties.
  /// </summary>
  public static LegacyNumbering? GetLegacyNumbering(Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LegacyNumbering>();
    if (itemElement != null)
      return LegacyNumberingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLegacyNumbering(Level? openXmlElement, LegacyNumbering? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LegacyNumbering>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LegacyNumberingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LegacyNumbering>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Justification.
  /// </summary>
  public static LevelJustificationKind? GetLevelJustification(Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LevelJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LevelJustificationValues, LevelJustificationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLevelJustification(Level? openXmlElement, LevelJustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LevelJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<LevelJustification, LevelJustificationValues, LevelJustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Numbering Level Associated Paragraph Properties.
  /// </summary>
  public static PreviousParagraphProperties? GetPreviousParagraphProperties(Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphProperties>();
    if (itemElement != null)
      return PreviousParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreviousParagraphProperties(Level? openXmlElement, PreviousParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Numbering Symbol Run Properties.
  /// </summary>
  public static NumberingSymbolRunProperties? GetNumberingSymbolRunProperties(Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties>();
    if (itemElement != null)
      return NumberingSymbolRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingSymbolRunProperties(Level? openXmlElement, NumberingSymbolRunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingSymbolRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Level? CreateModelElement(Level? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Level? value)
    where OpenXmlElementType : Level, new()
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