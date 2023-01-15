using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Grammar Checking Settings.
/// </summary>
public static class ActiveWritingStyleConverter
{
  /// <summary>
  ///   Writing Style Language
  /// </summary>
  public static String? GetLanguage(ActiveWritingStyle? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }

  public static void SetLanguage(ActiveWritingStyle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Language = new StringValue { Value = value };
      else
        openXmlElement.Language = null;
  }

  /// <summary>
  ///   Grammatical Engine ID
  /// </summary>
  public static UInt16? GetVendorID(ActiveWritingStyle? openXmlElement)
  {
    return openXmlElement?.VendorID?.Value;
  }

  public static void SetVendorID(ActiveWritingStyle? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
      openXmlElement.VendorID = value;
  }

  /// <summary>
  ///   Grammatical Check Engine Version
  /// </summary>
  public static Int32? GetDllVersion(ActiveWritingStyle? openXmlElement)
  {
    return openXmlElement?.DllVersion?.Value;
  }

  public static void SetDllVersion(ActiveWritingStyle? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DllVersion = value;
  }

  /// <summary>
  ///   Natural Language Grammar Check
  /// </summary>
  public static Boolean? GetNaturalLanguageGrammarCheck(ActiveWritingStyle? openXmlElement)
  {
    return openXmlElement?.NaturalLanguageGrammarCheck?.Value;
  }

  public static void SetNaturalLanguageGrammarCheck(ActiveWritingStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NaturalLanguageGrammarCheck = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.NaturalLanguageGrammarCheck = null;
  }

  /// <summary>
  ///   Check Stylistic Rules With Grammar
  /// </summary>
  public static Boolean? GetCheckStyle(ActiveWritingStyle? openXmlElement)
  {
    return openXmlElement?.CheckStyle?.Value;
  }

  public static void SetCheckStyle(ActiveWritingStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CheckStyle = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.CheckStyle = null;
  }

  /// <summary>
  ///   Application Name
  /// </summary>
  public static String? GetApplicationName(ActiveWritingStyle? openXmlElement)
  {
    return openXmlElement?.ApplicationName?.Value;
  }

  public static void SetApplicationName(ActiveWritingStyle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ApplicationName = new StringValue { Value = value };
      else
        openXmlElement.ApplicationName = null;
  }

  public static DocumentModel.Wordprocessing.ActiveWritingStyle? CreateModelElement(ActiveWritingStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ActiveWritingStyle();
      value.Language = GetLanguage(openXmlElement);
      value.VendorID = GetVendorID(openXmlElement);
      value.DllVersion = GetDllVersion(openXmlElement);
      value.NaturalLanguageGrammarCheck = GetNaturalLanguageGrammarCheck(openXmlElement);
      value.CheckStyle = GetCheckStyle(openXmlElement);
      value.ApplicationName = GetApplicationName(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ActiveWritingStyle? value)
    where OpenXmlElementType : ActiveWritingStyle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLanguage(openXmlElement, value?.Language);
      SetVendorID(openXmlElement, value?.VendorID);
      SetDllVersion(openXmlElement, value?.DllVersion);
      SetNaturalLanguageGrammarCheck(openXmlElement, value?.NaturalLanguageGrammarCheck);
      SetCheckStyle(openXmlElement, value?.CheckStyle);
      SetApplicationName(openXmlElement, value?.ApplicationName);
      return openXmlElement;
    }
    return default;
  }
}