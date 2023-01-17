namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Grammar Checking Settings.
/// </summary>
public static class ActiveWritingStyleConverter
{
  /// <summary>
  /// Writing Style Language
  /// </summary>
  private static String? GetLanguage(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  private static void SetLanguage(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// Grammatical Engine ID
  /// </summary>
  private static UInt16? GetVendorID(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement.VendorID?.Value;
  }
  
  private static void SetVendorID(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement, UInt16? value)
  {
    openXmlElement.VendorID = value;
  }
  
  /// <summary>
  /// Grammatical Check Engine Version
  /// </summary>
  private static Int32? GetDllVersion(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement.DllVersion?.Value;
  }
  
  private static void SetDllVersion(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement, Int32? value)
  {
    openXmlElement.DllVersion = value;
  }
  
  /// <summary>
  /// Natural Language Grammar Check
  /// </summary>
  private static Boolean? GetNaturalLanguageGrammarCheck(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement?.NaturalLanguageGrammarCheck?.Value;
  }
  
  private static void SetNaturalLanguageGrammarCheck(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NaturalLanguageGrammarCheck = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.NaturalLanguageGrammarCheck = null;
  }
  
  /// <summary>
  /// Check Stylistic Rules With Grammar
  /// </summary>
  private static Boolean? GetCheckStyle(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement?.CheckStyle?.Value;
  }
  
  private static void SetCheckStyle(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CheckStyle = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.CheckStyle = null;
  }
  
  /// <summary>
  /// Application Name
  /// </summary>
  private static String? GetApplicationName(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement?.ApplicationName?.Value;
  }
  
  private static void SetApplicationName(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ApplicationName = new StringValue { Value = value };
    else
      openXmlElement.ApplicationName = null;
  }
  
  public static DocumentModel.Wordprocessing.ActiveWritingStyle? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle, new()
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
