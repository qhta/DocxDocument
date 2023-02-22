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
    return StringValueConverter.GetValue(openXmlElement?.Language);
  }
  
  private static bool CmpLanguage(DXW.ActiveWritingStyle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Language, value, diffs, objName, "Language");
  }
  
  private static void SetLanguage(DXW.ActiveWritingStyle openXmlElement, String? value)
  {
    openXmlElement.Language = StringValueConverter.CreateStringValue(value);
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
    return BooleanValueConverter.GetValue(openXmlElement?.NaturalLanguageGrammarCheck);
  }
  
  private static bool CmpNaturalLanguageGrammarCheck(DXW.ActiveWritingStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.NaturalLanguageGrammarCheck, value, diffs, objName, "NaturalLanguageGrammarCheck");
  }
  
  private static void SetNaturalLanguageGrammarCheck(DXW.ActiveWritingStyle openXmlElement, Boolean? value)
  {
    openXmlElement.NaturalLanguageGrammarCheck = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Check Stylistic Rules With Grammar
  /// </summary>
  private static Boolean? GetCheckStyle(DXW.ActiveWritingStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.CheckStyle);
  }
  
  private static bool CmpCheckStyle(DXW.ActiveWritingStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.CheckStyle, value, diffs, objName, "CheckStyle");
  }
  
  private static void SetCheckStyle(DXW.ActiveWritingStyle openXmlElement, Boolean? value)
  {
    openXmlElement.CheckStyle = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Application Name
  /// </summary>
  private static String? GetApplicationName(DXW.ActiveWritingStyle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ApplicationName);
  }
  
  private static bool CmpApplicationName(DXW.ActiveWritingStyle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ApplicationName, value, diffs, objName, "ApplicationName");
  }
  
  private static void SetApplicationName(DXW.ActiveWritingStyle openXmlElement, String? value)
  {
    openXmlElement.ApplicationName = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Wordprocessing.ActiveWritingStyle? CreateModelElement(DXW.ActiveWritingStyle? openXmlElement)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ActiveWritingStyle value)
    where OpenXmlElementType: DXW.ActiveWritingStyle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ActiveWritingStyle openXmlElement, DMW.ActiveWritingStyle value)
  {
    SetLanguage(openXmlElement, value?.Language);
    SetVendorID(openXmlElement, value?.VendorID);
    SetDllVersion(openXmlElement, value?.DllVersion);
    SetNaturalLanguageGrammarCheck(openXmlElement, value?.NaturalLanguageGrammarCheck);
    SetCheckStyle(openXmlElement, value?.CheckStyle);
    SetApplicationName(openXmlElement, value?.ApplicationName);
    }
  }
