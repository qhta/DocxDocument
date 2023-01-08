namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Phonetic Guide Properties.
/// </summary>
public static class RubyPropertiesConverter
{
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  public static DocumentModel.Wordprocessing.RubyAlignKind? GetRubyAlign(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyAlign>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DocumentModel.Wordprocessing.RubyAlignKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetRubyAlign(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, DocumentModel.Wordprocessing.RubyAlignKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyAlign>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RubyAlign, DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DocumentModel.Wordprocessing.RubyAlignKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  public static String? GetPhoneticGuideTextFontSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideTextFontSize");
  }
  
  public static void SetPhoneticGuideTextFontSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public static Int16? GetPhoneticGuideRaise(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPhoneticGuideRaise(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  public static String? GetPhoneticGuideBaseTextSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideBaseTextSize");
  }
  
  public static void SetPhoneticGuideBaseTextSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  public static String? GetLanguageId(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.LanguageId");
  }
  
  public static void SetLanguageId(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  public static Boolean? GetDirty(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDirty(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
