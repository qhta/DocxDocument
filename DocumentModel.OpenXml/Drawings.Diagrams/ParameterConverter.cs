namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Parameter.
/// </summary>
public static class ParameterConverter
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  private static DMDrawsDgms.ParameterIdKind? GetType(DXDrawDgms.Parameter openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues, DMDrawsDgms.ParameterIdKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDrawDgms.Parameter openXmlElement, DMDrawsDgms.ParameterIdKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues, DMDrawsDgms.ParameterIdKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXDrawDgms.Parameter openXmlElement, DMDrawsDgms.ParameterIdKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues, DMDrawsDgms.ParameterIdKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.Parameter openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXDrawDgms.Parameter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Val");
  }
  
  private static void SetVal(DXDrawDgms.Parameter openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Diagrams.Parameter? CreateModelElement(DXDrawDgms.Parameter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Parameter();
      value.Type = GetType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.Parameter? openXmlElement, DMDrawsDgms.Parameter? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Parameter value)
    where OpenXmlElementType: DXDrawDgms.Parameter, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Parameter openXmlElement, DMDrawsDgms.Parameter value)
  {
    SetType(openXmlElement, value?.Type);
    SetVal(openXmlElement, value?.Val);
    }
  }
