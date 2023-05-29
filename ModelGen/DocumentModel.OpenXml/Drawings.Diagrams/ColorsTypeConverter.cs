namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public static class ColorsTypeConverter
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  private static DMDrawsDgms.ColorApplicationMethodKind? GetMethod(DXDrawDgms.ColorsType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DMDrawsDgms.ColorApplicationMethodKind>(openXmlElement?.Method?.Value);
  }
  
  private static bool CmpMethod(DXDrawDgms.ColorsType openXmlElement, DMDrawsDgms.ColorApplicationMethodKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DMDrawsDgms.ColorApplicationMethodKind>(openXmlElement?.Method?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMethod(DXDrawDgms.ColorsType openXmlElement, DMDrawsDgms.ColorApplicationMethodKind? value)
  {
    openXmlElement.Method = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DMDrawsDgms.ColorApplicationMethodKind>(value);
  }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  private static DMDrawsDgms.HueDirectionKind? GetHueDirection(DXDrawDgms.ColorsType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DMDrawsDgms.HueDirectionKind>(openXmlElement?.HueDirection?.Value);
  }
  
  private static bool CmpHueDirection(DXDrawDgms.ColorsType openXmlElement, DMDrawsDgms.HueDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DMDrawsDgms.HueDirectionKind>(openXmlElement?.HueDirection?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHueDirection(DXDrawDgms.ColorsType openXmlElement, DMDrawsDgms.HueDirectionKind? value)
  {
    openXmlElement.HueDirection = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DMDrawsDgms.HueDirectionKind>(value);
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorsType? CreateModelElement(DXDrawDgms.ColorsType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorsType();
      value.Method = GetMethod(openXmlElement);
      value.HueDirection = GetHueDirection(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.ColorsType? openXmlElement, DMDrawsDgms.ColorsType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMethod(openXmlElement, value.Method, diffs, objName))
        ok = false;
      if (!CmpHueDirection(openXmlElement, value.HueDirection, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorsType value)
    where OpenXmlElementType: DXDrawDgms.ColorsType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.ColorsType openXmlElement, DMDrawsDgms.ColorsType value)
  {
    SetMethod(openXmlElement, value?.Method);
    SetHueDirection(openXmlElement, value?.HueDirection);
  }
}
