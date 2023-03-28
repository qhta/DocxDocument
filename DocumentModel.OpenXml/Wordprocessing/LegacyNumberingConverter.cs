namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Legacy Numbering Level Properties converter from/to OpenXML converter from/to OpenXml.
///</summary>
public static class LegacyNumberingConverter
{
  #region Use Legacy Numbering Properties
  private static Boolean? GetLegacy(DXW.LegacyNumbering openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Legacy);
  }
  
  private static bool CmpLegacy(DXW.LegacyNumbering openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Legacy, value, diffs, objName, "Legacy");
  }
  
  private static void SetLegacy(DXW.LegacyNumbering openXmlElement, Boolean? value)
  {
    openXmlElement.Legacy = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region Legacy Spacing
  private static DXA? GetLegacySpace(DXW.LegacyNumbering openXmlElement)
  {
    if (openXmlElement?.LegacySpace!=null)
      return Int32ValueConverter.GetValue(openXmlElement.LegacySpace);
    return null;
  }
  
  private static bool CmpLegacySpace(DXW.LegacyNumbering openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LegacySpace, value, diffs, objName, "LegacySpace");
  }
  
  private static void SetLegacySpace(DXW.LegacyNumbering openXmlElement, String? value)
  {
    openXmlElement.LegacySpace = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Legacy Indent
  private static DXA? GetLegacyIndent(DXW.LegacyNumbering openXmlElement)
  {
    if (openXmlElement?.LegacyIndent!=null)
      return Int32ValueConverter.GetValue(openXmlElement.LegacyIndent);
    return null;
  }

  private static bool CmpLegacyIndent(DXW.LegacyNumbering openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LegacyIndent, value, diffs, objName, "LegacyIndent");
  }
  
  private static void SetLegacyIndent(DXW.LegacyNumbering openXmlElement, String? value)
  {
    openXmlElement.LegacyIndent = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region LegacyNumbering model conversion
  public static DMW.LegacyNumbering? CreateModelElement(DXW.LegacyNumbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LegacyNumbering();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.LegacyNumbering value)
    where OpenXmlElementType: DXW.LegacyNumbering, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.LegacyNumbering openXmlElement, DMW.LegacyNumbering value)
  {
    SetLegacy(openXmlElement, value?.Legacy);
    SetLegacySpace(openXmlElement, value?.LegacySpace);
    SetLegacyIndent(openXmlElement, value?.LegacyIndent);
  }
  #endregion
}
