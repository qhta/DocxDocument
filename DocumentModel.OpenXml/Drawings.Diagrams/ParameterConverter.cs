namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Parameter.
/// </summary>
public static class ParameterConverter
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  private static DMDD.ParameterIdKind? GetType(DXDD.Parameter openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues, DMDD.ParameterIdKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDD.Parameter openXmlElement, DMDD.ParameterIdKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues, DMDD.ParameterIdKind>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXDD.Parameter openXmlElement, DMDD.ParameterIdKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues, DMDD.ParameterIdKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static String? GetVal(DXDD.Parameter openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXDD.Parameter openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetVal(DXDD.Parameter openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMDD.Parameter? CreateModelElement(DXDD.Parameter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.Parameter();
      value.Type = GetType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.Parameter? openXmlElement, DMDD.Parameter? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Parameter value)
    where OpenXmlElementType: DXDD.Parameter, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Parameter openXmlElement, DMDD.Parameter value)
  {
    SetType(openXmlElement, value?.Type);
    SetVal(openXmlElement, value?.Val);
  }
}
