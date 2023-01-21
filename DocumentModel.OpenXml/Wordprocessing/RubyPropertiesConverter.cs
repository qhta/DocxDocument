namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Phonetic Guide Properties.
/// </summary>
public static class RubyPropertiesConverter
{
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  private static DocumentModel.Wordprocessing.RubyAlignKind? GetRubyAlign(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyAlign>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DocumentModel.Wordprocessing.RubyAlignKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetRubyAlign(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement, DocumentModel.Wordprocessing.RubyAlignKind? value)
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
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  private static String? GetPhoneticGuideTextFontSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideTextFontSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPhoneticGuideTextFontSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideTextFontSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideTextFontSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  private static Int16? GetPhoneticGuideRaise(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideRaise>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPhoneticGuideRaise(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement, Int16? value)
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
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  private static String? GetPhoneticGuideBaseTextSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideBaseTextSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPhoneticGuideBaseTextSize(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideBaseTextSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideBaseTextSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  private static String? GetLanguageId(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LanguageId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLanguageId(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LanguageId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.LanguageId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  private static Boolean? GetDirty(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Dirty>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDirty(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement, Boolean? value)
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
