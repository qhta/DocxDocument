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
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideTextFontSize");
  }
  
  public static void SetPhoneticGuideTextFontSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideTextFontSize");
  }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public static Int16? GetPhoneticGuideRaise(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideRaise>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetPhoneticGuideRaise(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideRaise>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideRaise{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  public static String? GetPhoneticGuideBaseTextSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideBaseTextSize");
  }
  
  public static void SetPhoneticGuideBaseTextSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideBaseTextSize");
  }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  public static String? GetLanguageId(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.LanguageId");
  }
  
  public static void SetLanguageId(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.LanguageId");
  }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  public static Boolean? GetDirty(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Dirty>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDirty(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Dirty>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Dirty();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.RubyProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RubyProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RubyProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.RubyProperties, new()
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
