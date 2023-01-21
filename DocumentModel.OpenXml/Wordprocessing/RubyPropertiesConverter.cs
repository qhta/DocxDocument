namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Phonetic Guide Properties.
/// </summary>
public static class RubyPropertiesConverter
{
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  private static DMW.RubyAlignKind? GetRubyAlign(DXW.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyAlign>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetRubyAlign(DXW.RubyProperties openXmlElement, DMW.RubyAlignKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyAlign>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.RubyAlign, DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  private static String? GetPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PhoneticGuideTextFontSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPhoneticGuideTextFontSize(DXW.RubyProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PhoneticGuideTextFontSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.PhoneticGuideTextFontSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  private static Int16? GetPhoneticGuideRaise(DXW.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PhoneticGuideRaise>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPhoneticGuideRaise(DXW.RubyProperties openXmlElement, Int16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PhoneticGuideRaise>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.PhoneticGuideRaise{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  private static String? GetPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PhoneticGuideBaseTextSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPhoneticGuideBaseTextSize(DXW.RubyProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PhoneticGuideBaseTextSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.PhoneticGuideBaseTextSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  private static String? GetLanguageId(DXW.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LanguageId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLanguageId(DXW.RubyProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LanguageId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.LanguageId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  private static Boolean? GetDirty(DXW.RubyProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Dirty>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDirty(DXW.RubyProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Dirty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Dirty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.RubyProperties? CreateModelElement(DXW.RubyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RubyProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RubyProperties? value)
    where OpenXmlElementType: DXW.RubyProperties, new()
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
