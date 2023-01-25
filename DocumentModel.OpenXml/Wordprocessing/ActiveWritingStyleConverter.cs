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
  
  private static bool CmpLanguage(DXW.ActiveWritingStyle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Language?.Value == value;
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
    return openXmlElement?.VendorID?.Value;
  }
  
  private static bool CmpVendorID(DXW.ActiveWritingStyle openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VendorID?.Value == value) return true;
    diffs?.Add(objName, "VendorID", openXmlElement?.VendorID?.Value, value);
    return false;
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
    return openXmlElement?.DllVersion?.Value;
  }
  
  private static bool CmpDllVersion(DXW.ActiveWritingStyle openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DllVersion?.Value == value) return true;
    diffs?.Add(objName, "DllVersion", openXmlElement?.DllVersion?.Value, value);
    return false;
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
  
  private static bool CmpNaturalLanguageGrammarCheck(DXW.ActiveWritingStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NaturalLanguageGrammarCheck?.Value == value;
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
  
  private static bool CmpCheckStyle(DXW.ActiveWritingStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CheckStyle?.Value == value;
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
  
  private static bool CmpApplicationName(DXW.ActiveWritingStyle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ApplicationName?.Value == value;
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
  
  public static bool CompareModelElement(DXW.ActiveWritingStyle? openXmlElement, DMW.ActiveWritingStyle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLanguage(openXmlElement, value.Language, diffs, objName))
        ok = false;
      if (!CmpVendorID(openXmlElement, value.VendorID, diffs, objName))
        ok = false;
      if (!CmpDllVersion(openXmlElement, value.DllVersion, diffs, objName))
        ok = false;
      if (!CmpNaturalLanguageGrammarCheck(openXmlElement, value.NaturalLanguageGrammarCheck, diffs, objName))
        ok = false;
      if (!CmpCheckStyle(openXmlElement, value.CheckStyle, diffs, objName))
        ok = false;
      if (!CmpApplicationName(openXmlElement, value.ApplicationName, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
