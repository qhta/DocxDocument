namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Legacy Numbering Level Properties.
/// </summary>
public static class LegacyNumberingConverter
{
  /// <summary>
  /// Use Legacy Numbering Properties
  /// </summary>
  private static Boolean? GetLegacy(DXW.LegacyNumbering openXmlElement)
  {
    return openXmlElement?.Legacy?.Value;
  }
  
  private static bool CmpLegacy(DXW.LegacyNumbering openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Legacy?.Value == value) return true;
    diffs?.Add(objName, "Legacy", openXmlElement?.Legacy?.Value, value);
    return false;
  }
  
  private static void SetLegacy(DXW.LegacyNumbering openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Legacy = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Legacy = null;
  }
  
  /// <summary>
  /// Legacy Spacing
  /// </summary>
  private static String? GetLegacySpace(DXW.LegacyNumbering openXmlElement)
  {
    return openXmlElement?.LegacySpace?.Value;
  }
  
  private static bool CmpLegacySpace(DXW.LegacyNumbering openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LegacySpace?.Value == value) return true;
    diffs?.Add(objName, "LegacySpace", openXmlElement?.LegacySpace?.Value, value);
    return false;
  }
  
  private static void SetLegacySpace(DXW.LegacyNumbering openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LegacySpace = new StringValue { Value = value };
    else
      openXmlElement.LegacySpace = null;
  }
  
  /// <summary>
  /// Legacy Indent
  /// </summary>
  private static String? GetLegacyIndent(DXW.LegacyNumbering openXmlElement)
  {
    return openXmlElement?.LegacyIndent?.Value;
  }
  
  private static bool CmpLegacyIndent(DXW.LegacyNumbering openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LegacyIndent?.Value == value) return true;
    diffs?.Add(objName, "LegacyIndent", openXmlElement?.LegacyIndent?.Value, value);
    return false;
  }
  
  private static void SetLegacyIndent(DXW.LegacyNumbering openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LegacyIndent = new StringValue { Value = value };
    else
      openXmlElement.LegacyIndent = null;
  }
  
  public static DocumentModel.Wordprocessing.LegacyNumbering? CreateModelElement(DXW.LegacyNumbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LegacyNumbering();
      value.Legacy = GetLegacy(openXmlElement);
      value.LegacySpace = GetLegacySpace(openXmlElement);
      value.LegacyIndent = GetLegacyIndent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LegacyNumbering? openXmlElement, DMW.LegacyNumbering? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLegacy(openXmlElement, value.Legacy, diffs, objName))
        ok = false;
      if (!CmpLegacySpace(openXmlElement, value.LegacySpace, diffs, objName))
        ok = false;
      if (!CmpLegacyIndent(openXmlElement, value.LegacyIndent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.LegacyNumbering? value)
    where OpenXmlElementType: DXW.LegacyNumbering, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLegacy(openXmlElement, value?.Legacy);
      SetLegacySpace(openXmlElement, value?.LegacySpace);
      SetLegacyIndent(openXmlElement, value?.LegacyIndent);
      return openXmlElement;
    }
    return default;
  }
}
