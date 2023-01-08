namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Level Definition.
/// </summary>
public static class LevelConverter
{
  /// <summary>
  /// Numbering Level
  /// </summary>
  public static Int32? GetLevelIndex(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLevelIndex(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Template Code
  /// </summary>
  public static DocumentModel.HexBinary? GetTemplateCode(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTemplateCode(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Tentative Numbering
  /// </summary>
  public static Boolean? GetTentative(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTentative(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Starting Value.
  /// </summary>
  public static Int32? GetStartNumberingValue(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStartNumberingValue(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Numbering Format.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.NumberingFormat? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Restart Numbering Level Symbol.
  /// </summary>
  public static Int32? GetLevelRestart(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLevelRestart(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Paragraph Style's Associated Numbering Level.
  /// </summary>
  public static String? GetParagraphStyleIdInLevel(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.ParagraphStyleIdInLevel");
  }
  
  public static void SetParagraphStyleIdInLevel(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Display All Levels Using Arabic Numerals.
  /// </summary>
  public static Boolean? GetIsLegalNumberingStyle(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIsLegalNumberingStyle(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  public static DocumentModel.Wordprocessing.LevelSuffixKind? GetLevelSuffix(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelSuffix>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DocumentModel.Wordprocessing.LevelSuffixKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLevelSuffix(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.LevelSuffixKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelSuffix>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelSuffix, DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DocumentModel.Wordprocessing.LevelSuffixKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Numbering Level Text.
  /// </summary>
  public static DocumentModel.Wordprocessing.LevelText? GetLevelText(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLevelText(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.LevelText? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Picture Numbering Symbol Definition Reference.
  /// </summary>
  public static Int32? GetLevelPictureBulletId(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLevelPictureBulletId(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Legacy Numbering Level Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.LegacyNumbering? GetLegacyNumbering(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLegacyNumbering(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.LegacyNumbering? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public static DocumentModel.Wordprocessing.LevelJustificationKind? GetLevelJustification(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelJustification>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DocumentModel.Wordprocessing.LevelJustificationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLevelJustification(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.LevelJustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelJustification, DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DocumentModel.Wordprocessing.LevelJustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Numbering Level Associated Paragraph Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.PreviousParagraphProperties? GetPreviousParagraphProperties(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPreviousParagraphProperties(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.PreviousParagraphProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Numbering Symbol Run Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingSymbolRunProperties? GetNumberingSymbolRunProperties(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberingSymbolRunProperties(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.NumberingSymbolRunProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
