namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineEndPropertiesType Class.
/// </summary>
public static class LineEndPropertiesTypeConverter
{
  /// <summary>
  /// Line Head/End Type
  /// </summary>
  private static DMDraws.LineEndKind? GetType(DXDraw.LineEndPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndValues, DMDraws.LineEndKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDraw.LineEndPropertiesType openXmlElement, DMDraws.LineEndKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LineEndValues, DMDraws.LineEndKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXDraw.LineEndPropertiesType openXmlElement, DMDraws.LineEndKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndValues, DMDraws.LineEndKind>(value);
  }
  
  /// <summary>
  /// Width of Head/End
  /// </summary>
  private static DMDraws.LineEndWidthKind? GetWidth(DXDraw.LineEndPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndWidthValues, DMDraws.LineEndWidthKind>(openXmlElement?.Width?.Value);
  }
  
  private static bool CmpWidth(DXDraw.LineEndPropertiesType openXmlElement, DMDraws.LineEndWidthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LineEndWidthValues, DMDraws.LineEndWidthKind>(openXmlElement?.Width?.Value, value, diffs, objName);
  }
  
  private static void SetWidth(DXDraw.LineEndPropertiesType openXmlElement, DMDraws.LineEndWidthKind? value)
  {
    openXmlElement.Width = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndWidthValues, DMDraws.LineEndWidthKind>(value);
  }
  
  /// <summary>
  /// Length of Head/End
  /// </summary>
  private static DMDraws.LineEndLengthKind? GetLength(DXDraw.LineEndPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndLengthValues, DMDraws.LineEndLengthKind>(openXmlElement?.Length?.Value);
  }
  
  private static bool CmpLength(DXDraw.LineEndPropertiesType openXmlElement, DMDraws.LineEndLengthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LineEndLengthValues, DMDraws.LineEndLengthKind>(openXmlElement?.Length?.Value, value, diffs, objName);
  }
  
  private static void SetLength(DXDraw.LineEndPropertiesType openXmlElement, DMDraws.LineEndLengthKind? value)
  {
    openXmlElement.Length = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndLengthValues, DMDraws.LineEndLengthKind>(value);
  }
  
  public static DocumentModel.Drawings.LineEndPropertiesType? CreateModelElement(DXDraw.LineEndPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineEndPropertiesType();
      value.Type = GetType(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Length = GetLength(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.LineEndPropertiesType? openXmlElement, DMDraws.LineEndPropertiesType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpLength(openXmlElement, value.Length, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LineEndPropertiesType value)
    where OpenXmlElementType: DXDraw.LineEndPropertiesType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.LineEndPropertiesType openXmlElement, DMDraws.LineEndPropertiesType value)
  {
    SetType(openXmlElement, value?.Type);
    SetWidth(openXmlElement, value?.Width);
    SetLength(openXmlElement, value?.Length);
  }
}
