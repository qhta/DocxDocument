namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineEndPropertiesType Class.
/// </summary>
public static class LineEndPropertiesTypeConverter
{
  /// <summary>
  /// Line Head/End Type
  /// </summary>
  private static DMD.LineEndKind? GetType(DXD.LineEndPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndValues, DMD.LineEndKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXD.LineEndPropertiesType openXmlElement, DMD.LineEndKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LineEndValues, DMD.LineEndKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXD.LineEndPropertiesType openXmlElement, DMD.LineEndKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndValues, DMD.LineEndKind>(value);
  }
  
  /// <summary>
  /// Width of Head/End
  /// </summary>
  private static DMD.LineEndWidthKind? GetWidth(DXD.LineEndPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndWidthValues, DMD.LineEndWidthKind>(openXmlElement?.Width?.Value);
  }
  
  private static bool CmpWidth(DXD.LineEndPropertiesType openXmlElement, DMD.LineEndWidthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LineEndWidthValues, DMD.LineEndWidthKind>(openXmlElement?.Width?.Value, value, diffs, objName);
  }
  
  private static void SetWidth(DXD.LineEndPropertiesType openXmlElement, DMD.LineEndWidthKind? value)
  {
    openXmlElement.Width = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndWidthValues, DMD.LineEndWidthKind>(value);
  }
  
  /// <summary>
  /// Length of Head/End
  /// </summary>
  private static DMD.LineEndLengthKind? GetLength(DXD.LineEndPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndLengthValues, DMD.LineEndLengthKind>(openXmlElement?.Length?.Value);
  }
  
  private static bool CmpLength(DXD.LineEndPropertiesType openXmlElement, DMD.LineEndLengthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LineEndLengthValues, DMD.LineEndLengthKind>(openXmlElement?.Length?.Value, value, diffs, objName);
  }
  
  private static void SetLength(DXD.LineEndPropertiesType openXmlElement, DMD.LineEndLengthKind? value)
  {
    openXmlElement.Length = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndLengthValues, DMD.LineEndLengthKind>(value);
  }
  
  public static DocumentModel.Drawings.LineEndPropertiesType? CreateModelElement(DXD.LineEndPropertiesType? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.LineEndPropertiesType? openXmlElement, DMD.LineEndPropertiesType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LineEndPropertiesType value)
    where OpenXmlElementType: DXD.LineEndPropertiesType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.LineEndPropertiesType openXmlElement, DMD.LineEndPropertiesType value)
  {
    SetType(openXmlElement, value?.Type);
    SetWidth(openXmlElement, value?.Width);
    SetLength(openXmlElement, value?.Length);
  }
}
