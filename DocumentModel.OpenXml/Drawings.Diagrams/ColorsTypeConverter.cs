namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public static class ColorsTypeConverter
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  private static DMDD.ColorApplicationMethodKind? GetMethod(DXDD.ColorsType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DMDD.ColorApplicationMethodKind>(openXmlElement?.Method?.Value);
  }
  
  private static bool CmpMethod(DXDD.ColorsType openXmlElement, DMDD.ColorApplicationMethodKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DMDD.ColorApplicationMethodKind>(openXmlElement?.Method?.Value, value, diffs, objName, propName);
  }
  
  private static void SetMethod(DXDD.ColorsType openXmlElement, DMDD.ColorApplicationMethodKind? value)
  {
    openXmlElement.Method = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DMDD.ColorApplicationMethodKind>(value);
  }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  private static DMDD.HueDirectionKind? GetHueDirection(DXDD.ColorsType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DMDD.HueDirectionKind>(openXmlElement?.HueDirection?.Value);
  }
  
  private static bool CmpHueDirection(DXDD.ColorsType openXmlElement, DMDD.HueDirectionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DMDD.HueDirectionKind>(openXmlElement?.HueDirection?.Value, value, diffs, objName, propName);
  }
  
  private static void SetHueDirection(DXDD.ColorsType openXmlElement, DMDD.HueDirectionKind? value)
  {
    openXmlElement.HueDirection = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DMDD.HueDirectionKind>(value);
  }
  
  public static DMDD.ColorsType? CreateModelElement(DXDD.ColorsType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.ColorsType();
      value.Method = GetMethod(openXmlElement);
      value.HueDirection = GetHueDirection(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.ColorsType? openXmlElement, DMDD.ColorsType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMethod(openXmlElement, value.Method, diffs, objName, propName))
        ok = false;
      if (!CmpHueDirection(openXmlElement, value.HueDirection, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.ColorsType value)
    where OpenXmlElementType: DXDD.ColorsType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.ColorsType openXmlElement, DMDD.ColorsType value)
  {
    SetMethod(openXmlElement, value?.Method);
    SetHueDirection(openXmlElement, value?.HueDirection);
  }
}
