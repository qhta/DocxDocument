namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  /// Break Type
  /// </summary>
  private static DMW.BreakKind? GetType(DXW.Break openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues, DMW.BreakKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.Break openXmlElement, DMW.BreakKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues, DMW.BreakKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXW.Break openXmlElement, DMW.BreakKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues, DMW.BreakKind>(value);
  }
  
  /// <summary>
  /// Restart Location For Text Wrapping Break
  /// </summary>
  private static DMW.BreakTextRestartLocationKind? GetClear(DXW.Break openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues, DMW.BreakTextRestartLocationKind>(openXmlElement?.Clear?.Value);
  }
  
  private static bool CmpClear(DXW.Break openXmlElement, DMW.BreakTextRestartLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues, DMW.BreakTextRestartLocationKind>(openXmlElement?.Clear?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetClear(DXW.Break openXmlElement, DMW.BreakTextRestartLocationKind? value)
  {
    openXmlElement.Clear = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues, DMW.BreakTextRestartLocationKind>(value);
  }
  
  public static DMW.Break? CreateModelElement(DXW.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Break();
      value.Type = GetType(openXmlElement);
      value.Clear = GetClear(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Break? openXmlElement, DMW.Break? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpClear(openXmlElement, value.Clear, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Break? value)
    where OpenXmlElementType: DXW.Break, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetClear(openXmlElement, value?.Clear);
      return openXmlElement;
    }
    return default;
  }
}
