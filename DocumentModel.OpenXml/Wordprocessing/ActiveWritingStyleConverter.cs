namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Grammar Checking Settings.
/// </summary>
public static class ActiveWritingStyleConverter
{
  /// <summary>
  /// Writing Style Language
  /// </summary>
  private static String? GetLanguage(DXW.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  private static void SetLanguage(DXW.ActiveWritingStyle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// Grammatical Engine ID
  /// </summary>
  private static UInt16? GetVendorID(DXW.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement.VendorID?.Value;
  }
  
  private static void SetVendorID(DXW.ActiveWritingStyle openXmlElement, UInt16? value)
  {
    openXmlElement.VendorID = value;
  }
  
  /// <summary>
  /// Grammatical Check Engine Version
  /// </summary>
  private static Int32? GetDllVersion(DXW.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement.DllVersion?.Value;
  }
  
  private static void SetDllVersion(DXW.ActiveWritingStyle openXmlElement, Int32? value)
  {
    openXmlElement.DllVersion = value;
  }
  
  /// <summary>
  /// Natural Language Grammar Check
  /// </summary>
  private static Boolean? GetNaturalLanguageGrammarCheck(DXW.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement?.NaturalLanguageGrammarCheck?.Value;
  }
  
  private static void SetNaturalLanguageGrammarCheck(DXW.ActiveWritingStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NaturalLanguageGrammarCheck = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.NaturalLanguageGrammarCheck = null;
  }
  
  /// <summary>
  /// Check Stylistic Rules With Grammar
  /// </summary>
  private static Boolean? GetCheckStyle(DXW.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement?.CheckStyle?.Value;
  }
  
  private static void SetCheckStyle(DXW.ActiveWritingStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CheckStyle = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.CheckStyle = null;
  }
  
  /// <summary>
  /// Application Name
  /// </summary>
  private static String? GetApplicationName(DXW.ActiveWritingStyle openXmlElement)
  {
    return openXmlElement?.ApplicationName?.Value;
  }
  
  private static void SetApplicationName(DXW.ActiveWritingStyle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ApplicationName = new StringValue { Value = value };
    else
      openXmlElement.ApplicationName = null;
  }
  
  public static DMW.ActiveWritingStyle? CreateModelElement(DXW.ActiveWritingStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ActiveWritingStyle();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ActiveWritingStyle? value)
    where OpenXmlElementType: DXW.ActiveWritingStyle, new()
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
