namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MacroWllType Class.
/// </summary>
public static class MacroWllTypeConverter
{
  /// <summary>
  /// macroName
  /// </summary>
  private static String? GetMacroName(DXOW.MacroWllType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MacroName);
  }
  
  private static bool CmpMacroName(DXOW.MacroWllType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MacroName, value, diffs, objName, "MacroName");
  }
  
  private static void SetMacroName(DXOW.MacroWllType openXmlElement, String? value)
  {
    openXmlElement.MacroName = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.MacroWllType? CreateModelElement(DXOW.MacroWllType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MacroWllType();
      value.MacroName = GetMacroName(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.MacroWllType? openXmlElement, DMW.MacroWllType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMacroName(openXmlElement, value.MacroName, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MacroWllType value)
    where OpenXmlElementType: DXOW.MacroWllType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.MacroWllType openXmlElement, DMW.MacroWllType value)
  {
    SetMacroName(openXmlElement, value?.MacroName);
  }
}
