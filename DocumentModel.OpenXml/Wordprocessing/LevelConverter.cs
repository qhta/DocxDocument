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
    return openXmlElement?.LevelIndex?.Value;
  }
  
  public static void SetLevelIndex(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LevelIndex = value;
  }
  
  /// <summary>
  /// Template Code
  /// </summary>
  public static DocumentModel.HexBinary? GetTemplateCode(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetTemplateCode(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// Tentative Numbering
  /// </summary>
  public static Boolean? GetTentative(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    return openXmlElement?.Tentative?.Value;
  }
  
  public static void SetTentative(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tentative = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Tentative = null;
  }
  
  /// <summary>
  /// Starting Value.
  /// </summary>
  public static Int32? GetStartNumberingValue(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.StartNumberingValue");
  }
  
  public static void SetStartNumberingValue(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.StartNumberingValue");
  }
  
  /// <summary>
  /// Numbering Format.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.NumberingFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.NumberingFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Restart Numbering Level Symbol.
  /// </summary>
  public static Int32? GetLevelRestart(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.LevelRestart");
  }
  
  public static void SetLevelRestart(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.LevelRestart");
  }
  
  /// <summary>
  /// Paragraph Style's Associated Numbering Level.
  /// </summary>
  public static String? GetParagraphStyleIdInLevel(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.ParagraphStyleIdInLevel");
  }
  
  public static void SetParagraphStyleIdInLevel(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.ParagraphStyleIdInLevel");
  }
  
  /// <summary>
  /// Display All Levels Using Arabic Numerals.
  /// </summary>
  public static Boolean? GetIsLegalNumberingStyle(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.IsLegalNumberingStyle>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetIsLegalNumberingStyle(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.IsLegalNumberingStyle>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.IsLegalNumberingStyle();
        openXmlElement.AddChild(itemElement);
      }
    }
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
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LevelTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLevelText(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.LevelText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.LevelTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Picture Numbering Symbol Definition Reference.
  /// </summary>
  public static Int32? GetLevelPictureBulletId(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.LevelPictureBulletId");
  }
  
  public static void SetLevelPictureBulletId(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.LevelPictureBulletId");
  }
  
  /// <summary>
  /// Legacy Numbering Level Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.LegacyNumbering? GetLegacyNumbering(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LegacyNumbering>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LegacyNumberingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLegacyNumbering(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.LegacyNumbering? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LegacyNumbering>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.LegacyNumberingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LegacyNumbering>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
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
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PreviousParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPreviousParagraphProperties(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.PreviousParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.PreviousParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Numbering Symbol Run Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingSymbolRunProperties? GetNumberingSymbolRunProperties(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.NumberingSymbolRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingSymbolRunProperties(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.NumberingSymbolRunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.NumberingSymbolRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Level? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Level, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
