using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using RubyProperties = DocumentFormat.OpenXml.Wordprocessing.RubyProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Phonetic Guide Properties.
/// </summary>
public static class RubyPropertiesConverter
{
  /// <summary>
  ///   Phonetic Guide Text Alignment.
  /// </summary>
  public static RubyAlignKind? GetRubyAlign(RubyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RubyAlign>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<RubyAlignValues, RubyAlignKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetRubyAlign(RubyProperties? openXmlElement, RubyAlignKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RubyAlign>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<RubyAlign, RubyAlignValues, RubyAlignKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Phonetic Guide Text Font Size.
  /// </summary>
  public static String? GetPhoneticGuideTextFontSize(RubyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PhoneticGuideTextFontSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPhoneticGuideTextFontSize(RubyProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PhoneticGuideTextFontSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PhoneticGuideTextFontSize { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public static Int16? GetPhoneticGuideRaise(RubyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PhoneticGuideRaise>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPhoneticGuideRaise(RubyProperties? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PhoneticGuideRaise>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PhoneticGuideRaise { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Phonetic Guide Base Text Font Size.
  /// </summary>
  public static String? GetPhoneticGuideBaseTextSize(RubyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PhoneticGuideBaseTextSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPhoneticGuideBaseTextSize(RubyProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PhoneticGuideBaseTextSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PhoneticGuideBaseTextSize { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Language ID for Phonetic Guide.
  /// </summary>
  public static String? GetLanguageId(RubyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LanguageId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLanguageId(RubyProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LanguageId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LanguageId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Invalidated Field Cache.
  /// </summary>
  public static Boolean? GetDirty(RubyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Dirty>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDirty(RubyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Dirty>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Dirty();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.RubyProperties? CreateModelElement(RubyProperties? openXmlElement)
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
    where OpenXmlElementType : RubyProperties, new()
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